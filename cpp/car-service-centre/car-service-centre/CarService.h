#pragma once
#include "Car.h"

class CarService
{
protected:
	static int ID;

public:
	virtual void addCar(Car* car) = 0;
	virtual void removeCar() = 0;
	virtual void showCars() = 0;
};

