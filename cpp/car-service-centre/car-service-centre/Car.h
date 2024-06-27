#pragma once
#include <string>
#include <iostream>
#include "Color.h"
#include "Brand.h"

using namespace std;

class Car
{
private:
	int id;
	Brand brand;
	Color color;
	string problem;

public:
	Car(Brand _brand, Color _color, string _problem);
	int getId();
	void setId(int _id);
	Brand getBrand();
	Color getColor();
	string getProblem();
};

