#pragma once
#include <iostream>
#include <string>
#include <iomanip>
#include "CreateCarService.h"
#include "Color.h"
#include "Brand.h"

using namespace std;

class Menu
{
public:
	void showMainMenu();
	void showMenu();
	void addCarRealisation();
	void removeCarRealisation();
	void showCarsRealisation();
	static void clearScreen();
	static void waitUntilPress();
};

