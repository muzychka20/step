#ifndef PICKUPFACTORY_H
#define PICKUPFACTORY_H

#include "pickup.h"
#include "car.h"
#include "carfactory.h"

class PickupFactory : public CarFactory
{
public:
    Car* createCar(int countWheels, Color color) override;
};

#endif // PICKUPFACTORY_H
