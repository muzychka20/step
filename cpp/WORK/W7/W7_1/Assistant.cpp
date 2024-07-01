#include "Assistant.h"

Assistant::Assistant(string name, int age, vector<string> disciplines) : Person(name, age)
{
	this->disciplines = disciplines;
}