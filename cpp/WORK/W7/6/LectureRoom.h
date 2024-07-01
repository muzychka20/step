#pragma once
#include "Classroom.h"

class LectureRoom : public Classroom
{
public:
	string projectorModel;

	LectureRoom(int roomNumber, int capacity, bool available, string projectorModel);		
	void showInfoClassroom() override;
};