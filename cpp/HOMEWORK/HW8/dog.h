#ifndef DOG_H
#define DOG_H
#include "animal.h"

class Dog : public Animal
{
public:
    Dog();
    void movement() override;
    void voice() override;
    void defend();
};

#endif // DOG_H
