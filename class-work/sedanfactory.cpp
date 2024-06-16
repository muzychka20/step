#include "sedanfactory.h"

Car* SedanFactory::createCar(int countWheels, Color color) {
    int places;
    cout << "Enter places: "; cin >> places;
    return new Sedan(countWheels, color, places);
}
