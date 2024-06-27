#include "Car.h"

Car::Car(Brand _brand, Color _color, string _problem) : brand(_brand), color(_color), problem(_problem) {}

int Car::getId()
{
	return id;
}

void Car::setId(int _id)
{
	id = _id;
}

Brand Car::getBrand()
{
	return brand;
}

Color Car::getColor()
{
	return color;
}

string Car::getProblem()
{
	return problem;
}
