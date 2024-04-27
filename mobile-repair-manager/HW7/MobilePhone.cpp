#include "MobilePhone.h"

int MobilePhone::ID = 1;

MobilePhone::MobilePhone(string model, string owner) : model(model), owner(owner) { this->id = this->ID++; repairStatus = false; }

MobilePhone::MobilePhone(string model, string owner, bool status) : model(model), owner(owner), repairStatus(status) { this->id = this->ID++; }

int MobilePhone::getID()
{
    return this->id;
}

bool MobilePhone::getStatus()
{
    return this->repairStatus;
}

string MobilePhone::getModel()
{
    return this->model;
}

string MobilePhone::getOwner()
{
    return this->owner;
}

void MobilePhone::setModel(string newModel)
{
    this->model = newModel;
}

void MobilePhone::setOwner(string newOwner)
{
    this->model = newOwner;
}

void MobilePhone::showRepairStatus()
{
    cout << "Repair Status: " << (this->repairStatus ? "Fixed" : "Under repair") << endl;
}

void MobilePhone::changeRepairStatus()
{
	this->repairStatus = !this->repairStatus;
}

void MobilePhone::showMobilePhoneInfo()
{
    cout << "ID: " << this->getID() << endl;
    cout << "Model: " << this->getModel() << endl;
    cout << "Owner: " << this->getOwner() << endl;
    this->showRepairStatus();
}
