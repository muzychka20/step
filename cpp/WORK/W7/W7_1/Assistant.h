#pragma once
#include "Person.h"
#include <vector>

class Assistant : public Person
{
public:
	vector<string> disciplines;

	Assistant(string name, int age, vector<string> disciplines);
};

