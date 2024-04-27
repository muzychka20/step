#include "RepairService.h"

void RepairService::addPhoneForRepair(MobilePhone phone)
{
	listRepairment.push_back(phone);
}

int RepairService::findIndexPhoneById(int id)
{
	for (int i = 0; i < listRepairment.size(); i++)
	{
		if (listRepairment[i].getID() == id)
		{
			return i;
		}
	}
	return -1;
}

int RepairService::changeStatusOfRepairByID(int id)
{
	int index = this->findIndexPhoneById(id);

	if (index == -1)
	{
		cout << "Phone not found!\n";
		return -1;
	}

	listRepairment[index].changeRepairStatus();

	return index;
}

void RepairService::changeStatusAndDelete()
{
	int id;
	bool validInput = false;

	while (!validInput)
	{
		try {
			cout << "Enter id: ";
			if (!(cin >> id)) {
				throw invalid_argument("Invalid input. Please enter a valid integer.");
			}
			validInput = true;
		}
		catch (invalid_argument& error) {
			cout << "Error!\n" << error.what() << endl;
			cin.clear();
			cin.ignore(numeric_limits<streamsize>::max(), '\n');
		}
	}

	int index = this->changeStatusOfRepairByID(id);
	if (index == -1)
		return;

	if (listRepairment[index].getStatus())
	{
		char t;
		cout << "Delete phone from list? (y/n): "; cin >> t;

		if (t == 'y')
			this->listRepairment.erase(listRepairment.begin() + index);
	}
}

void RepairService::showInfoListRepairment()
{
	for (auto& mobilePhone : this->listRepairment)
	{
		mobilePhone.showMobilePhoneInfo();
		cout << endl;
	}
}

void RepairService::registerPhone()
{
	string model, owner;
	cout << "Model: "; cin >> model;
	cout << "Owner: "; cin >> owner;
	MobilePhone phone(model, owner);
	this->addPhoneForRepair(phone);
}

void RepairService::saveInFileListRepairment()
{
	ofstream file;
	
	string fileName;
	cout << "Enter the name of file: "; cin >> fileName;

	file.open(fileName);

	for (int i = 0; i < listRepairment.size(); ++i) {
		file << listRepairment[i].getModel() << endl;
		file << listRepairment[i].getOwner() << endl;
		file << listRepairment[i].getStatus();
		
		if (i != listRepairment.size() - 1) {
			file << endl << endl;
		}
	}

	file.close();
	cout << "Saved!\n";
}

void RepairService::uploadFromFileListRepairment()
{
	this->listRepairment.clear();
	
	string fileName;
	cout << "Enter the name of file: "; cin >> fileName;

	ifstream file(fileName);
	string line;

	if (file.is_open())
	{		
		while (!file.eof())
		{
			string name, owner; bool status;

			file >> name;
			file >> owner;
			file >> status;

			getline(file, line);

			MobilePhone phone(name, owner, (bool)status);
			this->listRepairment.push_back(phone);
		}

	}
	cout << "Uploaded!\n";
}

