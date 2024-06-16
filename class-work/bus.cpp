#include "bus.h"

Bus::Bus(int _countWheels, Color _color, int _capacity) : Car(_countWheels, _color), capacity(_capacity)
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
        if (_capacity <= 8) {
            throw invalid_argument("Capacity should be greater than 8!\n");
        }
    } catch (invalid_argument& error) {
        cerr << error.what() << endl;
        capacity = 9;
    }
}

void Bus::displayInfo()
{
    Car::displayInfo();
    cout << "Capacity: " << capacity << endl;
}
