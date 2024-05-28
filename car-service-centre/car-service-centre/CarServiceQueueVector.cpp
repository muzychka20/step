#include "CarServiceQueueVector.h"

int CarServiceQueueVector::SIZE = 5;

CarServiceQueueVector::CarServiceQueueVector()
{
}

void CarServiceQueueVector::addCar(Car* car)
{
	if (cars.size() == SIZE)
	{
		cars.erase(cars.begin());
	}
	car->setId(ID++);
	cars.push_back(car);
	cout << "QueueVector: Car has been added!\n";
}

void CarServiceQueueVector::removeCar()
{
	if (!cars.empty())
	{
		cars.erase(cars.begin());
		cout << "QueueVector: Car has been removed!\n";
	}
}

void CarServiceQueueVector::showCars()
{
	vector<Car*> tempCars;
	while (!cars.empty())
	{
		cout << "Id: " << cars.front()->getId() << endl;
		cout << "Brand: " << brandToString(cars.front()->getBrand()) << endl;
		cout << "Color: " << colorToString(cars.front()->getColor()) << endl;
		cout << "Problem: " << cars.front()->getProblem() << endl;
		cout << "------------------\n";
		tempCars.push_back(cars.front());
		cars.erase(cars.begin());
	}
	while (!tempCars.empty())
	{
		cars.push_back(tempCars.front());
		tempCars.erase(tempCars.begin());
	}
	cout << "QueueVector: Cars have been shown!\n";
}