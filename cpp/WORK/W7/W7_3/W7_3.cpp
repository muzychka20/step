// «адание 3:  лассы Vehicle и его производные
// «адача : ќпределите класс Vehicle, который содержит атрибуты, такие как максимальна€ скорость и цвет.
// —оздайте производные классы Car и Bicycle. ласс Car должен добавл€ть атрибуты дл€ количества дверей и типа топлива, 
// в то врем€ как Bicycle должен иметь атрибут дл€ наличи€ скоростей.

#include <iostream>
#include "Car.h"
#include "Bicycle.h"

int main()
{
	Car car;
	car.color = "Black";
	car.maxSpeed = 180;
	car.amountDoors = 3;
	car.fuelType = "gasoline";
	
	car.showInfoCar();

	cout << endl;

	Bicycle bicycle;
	bicycle.color = "White";
	bicycle.maxSpeed = 40;
	bicycle.numberOfSpeeds = 5;

	bicycle.showBicycleInfo();

	return 0;
}