#include "Intern.h"

void Intern::showInfoIntern()
{
	this->showInfoEmployee();
	cout << "Period: " << this->period << endl;
	cout << "Mentor: " << this->mentor << endl;
}