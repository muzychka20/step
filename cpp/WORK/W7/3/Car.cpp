#include "Car.h"

void Car::showInfoCar()
{
	this->showInfoVehicle();
	cout << "Amount of doors: " << this->amountDoors << endl;
	cout << "Fuel type: " << this->fuelType << endl;
}