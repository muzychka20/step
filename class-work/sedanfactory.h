#ifndef SEDANFACTORY_H
#define SEDANFACTORY_H

#include "sedan.h"
#include "car.h"
#include "carfactory.h"

class SedanFactory : public CarFactory
{
public:
    Car* createCar(int countWheels, Color color) override;
};

#endif // SEDANFACTORY_H
