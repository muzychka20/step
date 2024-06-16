#ifndef STORE_H
#define STORE_H

#include <vector>
#include "car.h"

class Store
{
private:
    static vector<Car*> cars;

public:
    Store();
    static void pushCar(Car* car);
    static void showCars();
    static void deleteCar(int index);
};

#endif // STORE_H
