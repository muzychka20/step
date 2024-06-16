#include "car.h"

Car::Car(int _countWheels, Color _color) : countWheels(_countWheels), color(_color) {}

void Car::displayInfo()
{
    cout << "Color: " << colorToString(color) << endl;
    cout << "Wheels: " << countWheels << endl;
}
