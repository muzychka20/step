#include "CarServiceStackVector.h"

CarServiceStackVector::CarServiceStackVector()
{
}

void CarServiceStackVector::addCar(Car* car)
{
	car->setId(ID++);
	cars.push_back(car);
	cout << "StackVector: Car has been added!\n";
}

void CarServiceStackVector::removeCar()
{
	if (!cars.empty())
	{
		cars.pop_back();
		cout << "StackVector: Car has been removed!\n";
	}
}

void CarServiceStackVector::showCars()
{
	vector<Car*> tempCars;
	while (!cars.empty())
	{
		cout << "Id: " << cars.back()->getId() << endl;
		cout << "Brand: " << brandToString(cars.back()->getBrand()) << endl;
		cout << "Color: " << colorToString(cars.back()->getColor()) << endl;
		cout << "Brand: " << cars.back()->getProblem() << endl;
		cout << "------------------\n";
		tempCars.push_back(cars.back());
		cars.pop_back();
	}
	while (!tempCars.empty())
	{
		cars.push_back(tempCars.back());
		tempCars.pop_back();
	}
	cout << "StackVector: Cars have been shown!\n";
}
