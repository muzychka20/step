#pragma once
#include "Person.h"

class Student : public Person
{
private:
	std::string group;

public:
	Student(std::string _name, std::string _surname, std::string _group);
	void showInfo() override;
	void showGroup();
};

