#ifndef SEDAN_H
#define SEDAN_H

#include "car.h"

class Sedan : public Car
{
public:
    Sedan(int _countWheels, Color _color, int _countPlaces);
    void displayInfo() override;
    int countPlaces;
};

#endif // SEDAN_H
