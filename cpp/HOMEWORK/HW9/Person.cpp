#include "Person.h"

Person::Person(std::string _name, std::string _surname) : name(_name), surname(_surname) {}

void Person::showInfo()
{
	std::cout << "Name: " << name << std::endl;
	std::cout << "Surname: " << surname << std::endl;
}
