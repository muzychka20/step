#pragma once
#include "Person.h"

class Driver : public Person
{
private:
	std::string licenseCategory;
	int age;

public:
	Driver(std::string _name, std::string _surname, std::string _licenseCategory, int _age);
	void showInfo() override;
	void showLicenseCategory();
};

