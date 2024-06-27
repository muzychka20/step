#pragma once
#include <iostream>
#include <string>

using namespace std;

enum class Brand
{
	HONDA,
	SKODA,
	MAZDA,
	FORD,
	RENAULT,
	COUNT = 6
};

string brandToString(Brand brand);
