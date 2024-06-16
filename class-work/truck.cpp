#include "truck.h"

Truck::Truck(int _countWheels, Color _color, int _maxWeight) : Car(_countWheels, _color), maxWeight(_maxWeight)
{
    try {
        if (_countWheels < 4 || (_countWheels % 2)){
            throw invalid_argument("Wheels should be 4 or even!\n");
        }
    } catch (invalid_argument& error) {
        cerr << error.what() << endl;
        Car::countWheels = 4;
    }

    try {
        if (_maxWeight <= 3) {
            throw invalid_argument("Places should be greater than 3!\n");
        }
    } catch (invalid_argument& error) {
        cerr << error.what() << endl;
        maxWeight = 3;
    }
}

void Truck::displayInfo()
{
    Car::displayInfo();
    cout << "Max weight:" << maxWeight << endl;
}
