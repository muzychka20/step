#include "AccountStore.h"

std::vector<Account> AccountStore::accounts;

void AccountStore::registrateAccount()
{
	string name, surname; int money;
	cout << "Registration form\n";
	cout << "Enter name: "; cin >> name;
	cout << "Enter surname: "; cin >> surname;
	cout << "Enter money: "; cin >> money;

	FIO fio(name, surname);
	Account acc(fio, money);
	accounts.push_back(acc);
}

void AccountStore::removeAccount()
{
	int d_id;
	cout << "Enter id of account to delete: "; cin >> d_id;

	for (int i = 0; i < accounts.size(); i++)
	{
		if (accounts[i].getAccountId() == d_id)
		{
			accounts.erase(accounts.begin() + i);
			break;
		}
	}
}

void AccountStore::showAccounts()
{
	for (int i = 0; i < accounts.size(); i++)
	{
		accounts[i].getAccountInfo();
		cout << endl;
	}
}

Account* AccountStore::getAccount(int id)
{
	for (int i = 0; i < accounts.size(); i++)
	{
		if (accounts[i].getAccountId() == id)
		{
			return &accounts[i];
		}
	}
	return NULL;
}
