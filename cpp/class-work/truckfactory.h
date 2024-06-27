#ifndef TRUCKFACTORY_H
#define TRUCKFACTORY_H

#include "truck.h"
#include "car.h"
#include "carfactory.h"

class TruckFactory : public CarFactory
{
public:
    Car* createCar(int countWheels, Color color) override;
};

#endif // TRUCKFACTORY_H
