#ifndef CAR_H
#define CAR_H

#include "color.h"

class Car
{
public:
    Car(int _countWheels, Color _color);
    int countWheels;
    Color color;
    virtual void displayInfo();
};

#endif // CAR_H
