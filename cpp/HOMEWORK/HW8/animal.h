#ifndef ANIMAL_H
#define ANIMAL_H
#include <iostream>

using namespace std;

class Animal
{
public:
    Animal();
    virtual void movement();
    virtual void voice();
};

#endif // ANIMAL_H
