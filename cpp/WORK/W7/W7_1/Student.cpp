#include "Student.h"

Student::Student(string name, int age, int id) : Person(name, age)
{
	this->studentNumberID = id;
}

void Student::showStudentInfo()
{
	cout << "Name: " << this->name << endl;
	cout << "Age: " << this->age << endl;
	cout << "Student number: " << this->studentNumberID << endl;
}
