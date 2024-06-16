#include "pickupfactory.h"

Car* PickupFactory::createCar(int countWheels, Color color)
{
    int maxSpeed;
    cout << "Enter max speed: "; cin >> maxSpeed;
    return new Pickup(countWheels, color, maxSpeed);
}
