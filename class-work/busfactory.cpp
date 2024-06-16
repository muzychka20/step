#include "busfactory.h"

Car* BusFactory::createCar(int countWheels, Color color) {
    int capacity;
    cout << "Capacity: "; cin >> capacity;
    return new Bus(countWheels, color, capacity);
}
