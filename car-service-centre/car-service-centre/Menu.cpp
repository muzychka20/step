#include "Menu.h"

void Menu::showMainMenu()
{
    cout << "1. Queue\n";
    cout << "2. Stack\n";
    cout << "3. Vector(Queue)\n";
    cout << "4. Vector(Stack)\n";
    cout << "e. Exit\n";
}

void Menu::showMenu()
{
    cout << "1. Add Car\n";
    cout << "2. Remove Car\n";
    cout << "3. Show Cars\n";
    cout << "e. Exit\n";
}

void Menu::addCarRealisation()
{
    int brand, color, maxSize = max(static_cast<int>(Brand::COUNT), static_cast<int>(Color::COUNT)); string problem;
    for (int i = 0; i < maxSize; i++)
    {
        cout << setw(20);
        if (brandToString(static_cast<Brand>(i)) != "UNKNOWN")
        {
            cout << brandToString(static_cast<Brand>(i)) << "(" << i << ")";
        }
        cout << "\t\t" << setw(20);
        if (colorToString(static_cast<Color>(i)) != "UNKNOWN")
        {
            cout << colorToString(static_cast<Color>(i)) << "(" << i << ")";
        }       
        cout << endl;
    }
    cout << setw(0);
    cout << "Brand: ";  cin >> brand;
    cout << "Color: ";  cin >> color;
    cout << "Problem: ";  cin >> problem;
    CreateCarService::carService->addCar(new Car(static_cast<Brand>(brand), static_cast<Color>(color), problem));
}

void Menu::removeCarRealisation()
{
    CreateCarService::carService->removeCar();
}

void Menu::showCarsRealisation()
{
    CreateCarService::carService->showCars();
}

void Menu::clearScreen()
{
    system("cls");
}

void Menu::waitUntilPress()
{
    cout << "press any key to carry on...";
    cin.clear();
    cin.ignore(10000, '\n');
    cin.get();
}
