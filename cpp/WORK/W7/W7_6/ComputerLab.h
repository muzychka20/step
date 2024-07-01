#pragma once
#include "Classroom.h"

class ComputerLab : public Classroom
{
public:
    int numComputers;

    ComputerLab(int roomNumber, int capacity, bool available, int numComputers);        
    void showInfoClassroom() override;
};