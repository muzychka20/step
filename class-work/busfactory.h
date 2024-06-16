#ifndef BUSFACTORY_H
#define BUSFACTORY_H

#include "bus.h"
#include "car.h"
#include "carfactory.h"

class BusFactory : public CarFactory
{
public:
    Car* createCar(int countWheels, Color color) override;
};

#endif // BUSFACTORY_H
