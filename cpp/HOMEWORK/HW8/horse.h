#ifndef HORSE_H
#define HORSE_H
#include "animal.h"

class Horse : public Animal
{
public:
    Horse();
    void movement() override;
    void voice() override;
    void plow();
};

#endif // HORSE_H
