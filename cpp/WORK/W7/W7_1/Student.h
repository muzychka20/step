#pragma once
#include "Person.h"
#include <iostream>

using namespace std;

class Student : public Person
{
public:
	int studentNumberID;

	Student(string name, int age, int id);
	void showStudentInfo();
};

