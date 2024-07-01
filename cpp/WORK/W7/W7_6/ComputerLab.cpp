#include "ComputerLab.h"

ComputerLab::ComputerLab(int roomNumber, int capacity, bool available, int numComputers) : Classroom(roomNumber, capacity, available), numComputers(numComputers) {}

void ComputerLab::showInfoClassroom()
{
    cout << "Computer Lab" << endl;
    Classroom::showInfoClassroom();
    cout << "Number of Computers: " << this->numComputers << endl;
}
