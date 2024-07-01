#pragma once
#include <iostream>
#include <string>

class Person
{
protected:
	std::string name;
	std::string surname;
public:
	Person(std::string _name, std::string _surname);	
	virtual void showInfo();	
};

