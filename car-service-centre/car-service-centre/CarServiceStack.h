#pragma once
#include <stack>
#include "Car.h"
#include "CarService.h"

class CarServiceStack : public CarService
{
private:	
	stack<Car*> cars;

public:
	CarServiceStack();
	void addCar(Car* car) override;
	void removeCar() override;
	void showCars() override;
};