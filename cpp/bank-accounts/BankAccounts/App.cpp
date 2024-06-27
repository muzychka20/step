#include "App.h"
#include "AccountStore.h"
#include "Menu.h"
#include "conio.h"

void App::RealisationMainMenu()
{
    char choose;
    while (true)
    {       
        Menu::ShowMainMenu();
        choose = _getche();     
        switch (choose)
        {
        case '1':            
            RealisationMenuManageAccounts();
            break;
        case '2':            
            RealisationMenuLogedAccount();
            break;
        case 27:
            exit(0);
        }
    }
}

void App::RealisationMenuManageAccounts()
{
    char choose;
    while (true)
    {
        Menu::ShowMenuManageAccounts();
        choose = _getche();
        system("cls");
        switch (choose)
        {
        case '1':
            AccountStore::registrateAccount();
            _getche();
            break;
        case '2':
            AccountStore::removeAccount();
            _getche();
            break;
        case '3':
            AccountStore::showAccounts();
            _getche();
            break;
        case 27:
            RealisationMainMenu();
            break;
        }        
    }
}

void App::RealisationMenuLogedAccount()
{
    int id; char choose;  
    system("cls");
    cout << "Enter id of account to login: "; cin >> id;
    Account *account = AccountStore::getAccount(id);
    if (account == NULL) RealisationMainMenu();
    while (true)
    {
        Menu::ShowMenuLogedAccount();
        choose = _getche();
        system("cls");
        switch (choose)
        {
        case '1':            
            account->showBalance();
            break;
        case '2':
            account->addMoney();
            break;
        case '3':
            account->cashOutMoney();
            break;
        case '4':        
            account->showFIO();
            break;        
        case '5':        
            account->changeFIO();
            break;        
        case '6':
            account->getCard();            
            break;
        case '7':
            account->changeCard();
            break;
        case '8':        
            account->changeStatus();            
            break;        
        case '9':
            account->getAccountInfo();
            break;
        case 27:
            RealisationMainMenu();
        }
        _getche();
    }
}
