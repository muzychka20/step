#include "CarServiceQueue.h"

int CarServiceQueue::SIZE = 5;

CarServiceQueue::CarServiceQueue()
{
}

void CarServiceQueue::addCar(Car* car)
{
	if (cars.size() == SIZE) 
	{
		cars.pop();
	}
	car->setId(ID++);
	cars.push(car);
	cout << "Queue: Car has been added!\n";
}

void CarServiceQueue::removeCar()
{
	if (!cars.empty())
	{
		cars.pop();
		cout << "Queue: Car has been removed!\n";
	}
}

void CarServiceQueue::showCars()
{
	queue<Car*> tempCars;
	while (!cars.empty())
	{		
		cout << "Id: " << cars.front()->getId() << endl;
		cout << "Brand: " << brandToString(cars.front()->getBrand()) << endl;
		cout << "Color: " << colorToString(cars.front()->getColor()) << endl;
		cout << "Problem: " << cars.front()->getProblem() << endl;
		cout << "------------------\n";
		tempCars.push(cars.front());
		cars.pop();
	}
	while (!tempCars.empty()) 
	{
		cars.push(tempCars.front());
		tempCars.pop();
	}
	cout << "Queue: Cars have been shown!\n";
}
