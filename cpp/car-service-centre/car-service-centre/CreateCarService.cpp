#include "CreateCarService.h"
#include "Menu.h"

CarService* CreateCarService::carService = nullptr;

CreateCarService::CreateCarService()
{
    Menu* menu = new Menu();
    char choose;    

    menu->showMainMenu();
    cin >> choose;

    switch (choose) {
    case 'e':
        exit(0);
        break;
    case '1':
        carService = new CarServiceQueue();
        break;
    case '2':
        carService = new CarServiceStack();
        break;
    case '3':
        carService = new CarServiceQueueVector();
        break;
    case '4':
        carService = new CarServiceStackVector();
        break;
    }

    menu->waitUntilPress();
    menu->clearScreen();
    
    delete menu;
}