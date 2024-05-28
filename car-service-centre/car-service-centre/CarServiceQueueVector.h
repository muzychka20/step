#pragma once
#include <vector>
#include "CarService.h"

using namespace std;

class CarServiceQueueVector : public CarService
{
private:
	static int SIZE;
	vector<Car*> cars;

public:
	CarServiceQueueVector();
	void addCar(Car* car) override;
	void removeCar() override;
	void showCars() override;
};
