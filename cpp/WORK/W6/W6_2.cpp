#include <iostream>
#include <conio.h>

using namespace std;

class FIO
{
public:
    string name;
    string surname;
    FIO() {};
    FIO(string name, string surname) : name(name), surname(surname) {}
};

class Card
{
public:
    int card_number;
    string card_type;
    int CVV;
    Card() {};
    Card(int card_number, string card_type, int CVV) : card_number(card_number), card_type(card_type), CVV(CVV) {}
};

class Account
{
private:    
    int summa;
    Card card;   
    FIO fio;
    string dateOfBirth;
    //bool blocked;

public:

    Account(FIO f, int s, string date)
    {    
        Card c(123456789, "debit", 123);
        fio = f;
        summa = s;        
        this->card = c;
        dateOfBirth = date;
    };
  
    int getCardNumber() { return card.card_number; }
    string getCardType() { return card.card_type; }
    int getCVV() { return card.CVV; }

    void setCard(Card c) { card.card_number = c.card_number; card.CVV = c.CVV;  card.card_type = c.card_type; }

    int getSumma() { return summa; }
    void addMoney(int s) { summa += s; }
    void cashOutMoney(int s) { if (s <= summa) summa -= s; }

    string getFIO() { return fio.name + " " + fio.surname; }
    void setFIO(FIO f) { fio = f; }

    string getDateOfBirth() { return dateOfBirth; }
    void setDateOfBirth(string date) { dateOfBirth = date; }

    
    //bool getStatus() { return blocked; }
    //void setStatus(bool status) { blocked = status; }
};

void Menu()
{
    cout << "1. Add money\n";
    cout << "2. Cash out money\n";
    cout << "3. Check balance\n";
    cout << "4. Change card\n";
    cout << "5. Change FIO\n";
    cout << "6. Get card info\n";
    cout << "7. Get FIO\n";
    cout << "8. Change date of birth\n";
    cout << "9. Get date of birth\n";
    cout << "10. Exit\n";
    
}

int main()
{
    FIO fio; int money; string date;
    cout << "Registration form\n";
    cout << "Enter name: "; cin >> fio.name;
    cout << "Enter surname: "; cin >> fio.surname;
    cout << "Enter money: "; cin >> money;
    cout << "Enter date of birth: "; cin >> date;
    
    Account acc(fio, money, date);

    int choose;

    while (true)
    {
        system("cls");
        Menu();
        cin >> choose;
        system("cls");

        if (choose == 10)
            break;

        switch (choose)
        {
            case 1:
                cout << "Enter money to add: ";  cin >> money;
                acc.addMoney(money);
                break;
            case 2:
                cout << "Enter money to cash out: ";  cin >> money;
                acc.cashOutMoney(money);
                break;
            case 3:
                cout << "Balance: " << acc.getSumma() << endl;
                break;      
            case 4:
            {
                int card_number, CVV; string card_type;
                cout << "New number: "; cin >> card_number;
                cout << "New cvv: "; cin >> CVV;
                cout << "New type: "; cin >> card_type;
                Card card(card_number, card_type, CVV);
                acc.setCard(card);
                break;        
            }
            case 5:
            {                
                cout << "New name: "; cin >> fio.name;
                cout << "New surname: "; cin >> fio.surname;
                acc.setFIO(fio);
                break;
            }
            case 6:
                cout << "Card number: " << acc.getCardNumber() << endl;
                cout << "Card type: " << acc.getCardType() << endl;
                cout << "Card CVV: " << acc.getCVV() << endl;
                break;
            case 7:                           
                cout << "FIO: " << acc.getFIO() << endl;
                break;
            case 8:
            {
                string date;
                cout << "New date of birth: "; cin >> date;
                acc.setDateOfBirth(date);
                break;
            }
            case 9:
                cout << "Date of birth: " << acc.getDateOfBirth() << endl;
                break;            
        }
        _getche();
    }

    return 0;
}