#include "CarServiceStack.h"

CarServiceStack::CarServiceStack()
{
}

void CarServiceStack::addCar(Car* car)
{
	car->setId(ID++);
	cars.push(car);
	cout << "Stack: Car has been added!\n";
}

void CarServiceStack::removeCar()
{
	if (!cars.empty())
	{
		cars.pop();
		cout << "Stack: Car has been removed!\n";
	}
}

void CarServiceStack::showCars()
{
	stack<Car*> tempCars;
	while (!cars.empty())
	{
		cout << "Id: " << cars.top()->getId() << endl;
		cout << "Brand: " << brandToString(cars.top()->getBrand()) << endl;
		cout << "Color: " << colorToString(cars.top()->getColor()) << endl;
		cout << "Brand: " << cars.top()->getProblem() << endl;
		cout << "------------------\n";
		tempCars.push(cars.top());
		cars.pop();
	}
	while (!tempCars.empty())
	{
		cars.push(tempCars.top());
		tempCars.pop();
	}
	cout << "Stack: Cars have been shown!\n";	
}