#ifndef TRUCK_H
#define TRUCK_H

#include "car.h"

class Truck : public Car
{
public:    
    Truck(int _countWheels, Color _color, int _maxWeight);
    void displayInfo() override;
    int maxWeight;
};

#endif // TRUCK_H
