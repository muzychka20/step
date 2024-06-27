#ifndef CARFACTORY_H
#define CARFACTORY_H

#include "car.h"

class CarFactory
{    
public:
    virtual Car* createCar(int countWheels, Color color) = 0;
    virtual ~CarFactory() = default;
};

#endif // CARFACTORY_H
