#ifndef MENU_H
#define MENU_H

#include <iostream>
#include <iomanip>
#include "color.h"
#include "sedan.h"
#include "pickup.h"
#include "pickupfactory.h"
#include "sedanfactory.h"
#include "busfactory.h"
#include "truckfactory.h"
#include "truck.h"
#include "bus.h"
#include "store.h"
#include "carfactory.h"

using namespace std;

class Menu
{
public:
    Menu();
    void showColors();
    void showMainMenu();
    void realisationMainMenu();
    void showCarTypesMenu();
    void addCarItem();
    void deleteCarItem();
    void showCarsItem();
    void clearScreen();
    void waitUntilPress();
};

#endif // MENU_H
