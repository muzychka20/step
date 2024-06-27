#include "App.h"

App::App()
{
    CreateCarService* createdCarService = new CreateCarService();
    Menu* menu = new Menu();
    char choose;

    while (true) {        
        menu->clearScreen();
        menu->showMenu();
        cin >> choose;
        menu->clearScreen();
        switch (choose) {
        case 'e':
            exit(0);
            break;
        case '1':       
            menu->addCarRealisation();
            break;       
        case '2':
            menu->removeCarRealisation();
            break;
        case '3':
            menu->showCarsRealisation();
            break;        
        }
        menu->waitUntilPress();
        menu->clearScreen();
    }
}
