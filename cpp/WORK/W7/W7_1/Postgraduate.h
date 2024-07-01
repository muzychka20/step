#pragma once
#include "Student.h"
#include "Assistant.h"
class Postgraduate : public Student, public Assistant
{
public:
	Postgraduate(string name, int age, int id, vector<string> subjects);
	void showSubjects();
};

