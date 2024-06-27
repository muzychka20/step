#ifndef BUS_H
#define BUS_H

#include "car.h"

class Bus : public Car
{
public:    
    Bus(int _countWheels, Color _color, int _maxWeight);
    void displayInfo() override;
    int capacity;
};

#endif // BUS_H
