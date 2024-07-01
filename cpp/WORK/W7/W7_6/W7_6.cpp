// –азработать систему классов дл€ управлени€ учебным заведением.
// ¬ системе должны быть представлены три типа учебных аудиторий :
// лекционные аудитории, компьютерные классы и лаборатории.
// ¬се они имеют общие характеристики, такие как номер аудитории, вместимость и статус доступности,
// которые должны быть реализованы в базовом классе.

#include <iostream>
#include <vector>
#include "Classroom.h"
#include "LectureRoom.h"
#include "Laboratory.h"
#include "ComputerLab.h"

int main()
{
	vector<Classroom*> classrooms;

	classrooms.push_back(new LectureRoom(100, 50, true, "Epson ABC123"));
	classrooms.push_back(new ComputerLab(200, 30, false, 20));
	classrooms.push_back(new Laboratory(300, 20, true, "Microscopes"));

	for (auto classroom : classrooms) 
	{
		classroom->showInfoClassroom();
		cout << endl;
	}

	return 0;
}