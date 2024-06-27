#include "Account.h"

int Account::ID = 0;

Account::Account(FIO fio, int money)
{
	srand(time(0));
	int num = 100000000 + rand() % (999999999 - 100000000 + 1);
	int cvv = 100 + rand() % (999 - 100 + 1);

	Card card(num, "debit", cvv);
	this->fio = fio;
	this->summa = money;
	this->card = card;
	this->blocked = false;
	this->account_id = ID++;
};

void Account::getCard()
{
	cout << "Card number: " << this->card.getCardNumber() << endl;
	cout << "Card type: " << this->card.getCardType() << endl;
	cout << "Card CVV: " << this->card.getCVV() << endl;
}

void Account::setCard(Card card)
{
	this->card.setCardNumber(card.getCardNumber());
	this->card.setCardType(card.getCardType());
	this->card.setCVV(card.getCVV());
}

void Account::changeCard()
{
	int card_n, cvv; string type;
	cout << "Card number: "; cin >> card_n;
	cout << "Card type: "; cin >> type;
	cout << "CVV: "; cin >> cvv;
	Card card(card_n, type, cvv);
	setCard(card);
}

int Account::getSumma() { return this->summa; }
void Account::addMoney() 
{
	int money;
	cout << "How much money to deposit into the account: ";  cin >> money;	
	this->summa += money; 
}
void Account::cashOutMoney() 
{ 
	int money;
	cout << "How much to withdraw money from account: ";  cin >> money;
	if (money <= this->summa)
	{
		this->summa -= money;
	}
}

void Account::showBalance()
{
	cout << "Balance: " << getSumma() << endl;
}

string Account::getFIO() { return this->fio.getName() + " " + this->fio.getSurname(); }
void Account::setFIO(FIO fio) { this->fio.setName(fio.getName()); this->fio.setSurname(fio.getSurname()); }
void Account::showFIO() { cout << "FIO: " << getFIO() << endl; }

void Account::changeFIO()
{
	string name, surname;
	cout << "Name: "; cin >> name;
	cout << "Surname: "; cin >> surname;
	FIO fio(name, surname);
	setFIO(fio);
}

bool Account::getStatus() { return this->blocked; }
void Account::setStatus(bool status) { this->blocked = status; }
void Account::changeStatus() { setStatus(!(this->blocked)); cout << "Status changed!\n"; }

int Account::getAccountId() { return this->account_id; };

void Account::getAccountInfo()
{
	cout << "ID: " << getAccountId() << endl;
	cout << "Balance: " << getSumma() << endl;	
	cout << "Status: "; getStatus() ? cout << "blocked\n" : cout << "active\n";
	cout << "Card info:\n"; getCard();
	cout << "FIO: " << getFIO() << endl;
}