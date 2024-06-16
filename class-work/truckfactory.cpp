#include "truckfactory.h"

Car* TruckFactory::createCar(int countWheels, Color color)
{
    int weight;
    cout << "Max weight: "; cin >> weight;
    return new Truck(countWheels, color, weight);
}
