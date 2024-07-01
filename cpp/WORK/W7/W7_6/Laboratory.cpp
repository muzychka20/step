#include "Laboratory.h"

Laboratory::Laboratory(int roomNumber, int capacity, bool available, string equipment) : Classroom(roomNumber, capacity, available), equipment(equipment) {}

void Laboratory::showInfoClassroom()
{
    cout << "Laboratory" << endl;
    Classroom::showInfoClassroom();
    cout << "Equipment: " << this->equipment << endl;
}