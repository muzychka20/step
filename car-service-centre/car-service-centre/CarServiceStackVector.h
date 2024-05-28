#pragma once
#include <vector>
#include "CarService.h"

using namespace std;

class CarServiceStackVector : public CarService
{
private:
	vector<Car*> cars;

public:
	CarServiceStackVector();
	void addCar(Car* car) override;
	void removeCar() override;
	void showCars() override;
};

