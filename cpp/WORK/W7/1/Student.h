#pragma once
#include "Person.h"
#include <iostream>

using namespace std;

class Student : public Person
{
public:
	int studentNumberID;

	void showStudentInfo();
};

