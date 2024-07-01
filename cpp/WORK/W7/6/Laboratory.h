#pragma once
#include "Classroom.h"

class Laboratory : public Classroom
{
public:
    string equipment;

    Laboratory(int roomNumber, int capacity, bool available, string equipment);            
    void showInfoClassroom() override;
};