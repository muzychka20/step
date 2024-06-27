#ifndef PICKUP_H
#define PICKUP_H

#include "car.h"

class Pickup : public Car
{
public:
    Pickup(int _countWheels, Color _color, int _countPLaces);
    void displayInfo() override;
    int maxSpeed;
};

#endif // PICKUP_H
