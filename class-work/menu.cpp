#include "menu.h"

Menu::Menu() {}

void Menu::showMainMenu()
{
    cout << "1. Show car\n";
    cout << "2. Add car\n";
    cout << "3. Delete car\n";
    cout << "4. Exit\n";
}

void Menu::showCarTypesMenu()
{
    cout << "1. Pickup\n";
    cout << "2. Sedan\n";
    cout << "3. Truck\n";
    cout << "4. Bus\n";
    cout << "5. Back\n";
}

void Menu::deleteCarItem()
{
    int index;
    cout << "Enter the index: "; cin >> index;
    Store::deleteCar(index);
}

void Menu::showCarsItem()
{
    Store::showCars();
}

void Menu::showColors() {
    for (int i = 0; i < static_cast<int>(Color::COUNT); i++)
    {
        if (colorToString(static_cast<Color>(i)) != "UNKNOWN")
        {
            cout << "(" << i << ")" << colorToString(static_cast<Color>(i)) << endl;
        }
    }
}

void Menu::addCarItem()
{
    while (true) {
        int color, countWheels, choose;
        clearScreen();
        showCarTypesMenu();
        cout << "Enter: "; cin >> choose;
        if (choose == 5) {
            showMainMenu();
            realisationMainMenu();
            break;
        }
        clearScreen();
        showColors();
        cout << "Color: "; cin >> color;
        cout << "Count wheels: "; cin >> countWheels;
        CarFactory* factory = nullptr;
        switch(choose)
        {
            case 1:
                factory = new PickupFactory();
                break;
            case 2:
                factory = new SedanFactory();
                break;
            case 3:
                factory = new TruckFactory();
                break;
            case 4:
                factory = new BusFactory();
                break;
        }
        if (factory) {
            Car* car = factory->createCar(countWheels, static_cast<Color>(color));
            Store::pushCar(car);
            delete factory;
        }
        waitUntilPress();
        clearScreen();
    }
}

void Menu::realisationMainMenu()
{
    int choose;
    while (true) {
        clearScreen();
        showMainMenu();
        cout << "Enter: "; cin >> choose;
        clearScreen();
        switch (choose) {
        case 4:
            exit(0);
            break;
        case 1:
            showCarsItem();
            break;
        case 2:
            addCarItem();
            break;
        case 3:
            deleteCarItem();
            break;
        }
        waitUntilPress();
        clearScreen();
    }
}

void Menu::clearScreen()
{
    system("clear");
}

void Menu::waitUntilPress()
{
    cout << "press any key to carry on...";
    cin.clear();
    cin.ignore(10000, '\n');
    cin.get();
}
