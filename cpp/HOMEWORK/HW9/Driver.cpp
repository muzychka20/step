#include "Driver.h"

Driver::Driver(std::string _name, std::string _surname, std::string _licenseCategory, int _age) : Person(_name, _surname), licenseCategory(_licenseCategory), age(_age) {}

void Driver::showInfo()
{
	Person::showInfo();
	std::cout << "License: " << licenseCategory << std::endl;
	std::cout << "Age: " << age << std::endl;
}

void Driver::showLicenseCategory()
{
	std::cout << "License: " << licenseCategory << std::endl;
}