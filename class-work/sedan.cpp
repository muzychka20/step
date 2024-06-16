#include "sedan.h"

int WHEELS_SEDAN = 4;

Sedan::Sedan(int _countWheels, Color _color, int _countPlaces) : Car(_countWheels, _color), countPlaces(_countPlaces)
{
    try {
        if (_countWheels != WHEELS_SEDAN) {
            throw invalid_argument("Wheels should be 4!\n");
        }
    } catch (invalid_argument& error) {
        cerr << error.what() << endl;
        Car::countWheels = WHEELS_SEDAN;
    }

    try {
        if (_countPlaces <= 0) {
            throw invalid_argument("Places should be greater than 0!\n");
        }
    } catch (invalid_argument& error) {
        cerr << error.what() << endl;
        countPlaces = 1;
    }
}

void Sedan::displayInfo()
{
    Car::displayInfo();
    cout << "Places: " << countPlaces << endl;
}
