#include "Student.h"

Student::Student(std::string _name, std::string _surname, std::string _group) : Person(_name, _surname), group(_group) {}

void Student::showInfo()
{
	Person::showInfo();	
	std::cout << "Group: " << group << std::endl;
}

void Student::showGroup()
{
	std::cout << "Group: " << group << std::endl;
}