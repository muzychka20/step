#pragma once
#include "Employee.h"
class Intern : public Employee
{
public:
	string period;
	string mentor;

	void showInfoIntern();
};

