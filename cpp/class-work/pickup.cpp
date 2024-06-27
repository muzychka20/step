#include "pickup.h"

int WHEELS = 4;

Pickup::Pickup(int _countWheels, Color _color, int _speed) : Car(_countWheels, _color), maxSpeed(_speed)
{
    try {
        if (_countWheels != WHEELS) {
            throw invalid_argument("Wheels should be 4!\n");
        }
    } catch (invalid_argument& error) {
        cerr << error.what() << endl;
        Car::countWheels = WHEELS;
    }

    try {
        if (_speed <= 0) {
            throw invalid_argument("Speed should be positive!\n");
        }
    } catch (invalid_argument& error) {
        cerr << error.what() << endl;
        maxSpeed = 1;
    }
}

void Pickup::displayInfo()
{
    Car::displayInfo();
    cout << "Max speed: " << maxSpeed << endl;
}
