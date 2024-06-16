#include "store.h"

std::vector<Car*> Store::cars;

Store::Store() {}

void Store::pushCar(Car *car)
{
    cars.push_back(car);
}

void Store::showCars()
{
    cout << "---------------------\n";
    for (int i = 0; i < cars.size(); i++) {
        cars[i]->displayInfo();
        cout << "---------------------\n";
    }
}

void Store::deleteCar(int index)
{
    try {
        if (index >= cars.size()) {
            throw out_of_range("Out of range!");
        }
        cars.erase(cars.begin() + index);
    } catch (const out_of_range& error) {
        cerr << error.what() << endl;
    }
}
