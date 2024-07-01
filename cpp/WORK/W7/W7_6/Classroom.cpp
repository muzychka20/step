#include "Classroom.h"

Classroom::Classroom(int roomNumber, int capacity, bool available) : roomNumber(roomNumber), capacity(capacity), available(available) {}

void Classroom::showInfoClassroom()
{
    cout << "Room Number: " << this->roomNumber << endl;
    cout << "Capacity: " << this->capacity << " students" << endl;
    cout << "Availability: " << (this->available ? "Available" : "Occupied") << endl;
}
