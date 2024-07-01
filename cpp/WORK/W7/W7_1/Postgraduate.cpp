#include "Postgraduate.h"

Postgraduate::Postgraduate(string name, int age, int id, vector<string> subjects) :
	Student(name, age, id), Assistant(name, age, subjects)
{
}

void Postgraduate::showSubjects()
{
	cout << "Subjects: ";
	for (auto& el : this->disciplines)
	{
		cout << el << "; ";
	}
	cout << "\n";
}
