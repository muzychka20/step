#pragma once
#include <queue>
#include "Car.h"
#include "CarService.h"

class CarServiceQueue : public CarService
{
private:
	static int SIZE;
	queue<Car*> cars;

public:
	CarServiceQueue();
	void addCar(Car* car) override;
	void removeCar() override;
	void showCars() override;

};

