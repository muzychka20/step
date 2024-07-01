#pragma once
#include "Vehicle.h"
class Car : public Vehicle
{
public:
	int amountDoors;
	string fuelType;

	void showInfoCar();
};