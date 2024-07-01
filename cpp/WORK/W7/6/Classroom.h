#pragma once
#include <iostream>

using namespace std;

class Classroom
{
public:
    int roomNumber;
    int capacity;
    bool available;
    
    Classroom(int roomNumber, int capacity, bool available);
    void virtual showInfoClassroom();
};

