#include "Menu.h"

void Menu::ShowMainMenu()
{
    system("cls");
    cout << "1. Manage accounts\n";
    cout << "2. Log in\n";
    cout << "Esc - Exit\n";
}

void Menu::ShowMenuManageAccounts()
{
    system("cls");
    cout << "1. Add account\n";
    cout << "2. Delete account\n";
    cout << "3. Show all accounts\n";
    cout << "Esc - Back\n";
}

void Menu::ShowMenuLogedAccount()
{
    system("cls");
    cout << "1. Check balance\n";
    cout << "2. Add money\n";
    cout << "3. Cash out money\n";
    cout << "4. Get FIO\n";
    cout << "5. Change FIO\n";
    cout << "6. Get card info\n";
    cout << "7. Change card\n";
    cout << "8. Change status\n";
    cout << "9. Get info about account\n";
    cout << "Esc - Back\n";
}
