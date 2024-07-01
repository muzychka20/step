#include "LectureRoom.h"

LectureRoom::LectureRoom(int roomNumber, int capacity, bool available, string projectorModel) : Classroom(roomNumber, capacity, available), projectorModel(projectorModel) {}

void LectureRoom::showInfoClassroom()
{
    cout << "Lecture Room" << endl;
    Classroom::showInfoClassroom();
    cout << "Projector Model: " << this->projectorModel << endl;
}