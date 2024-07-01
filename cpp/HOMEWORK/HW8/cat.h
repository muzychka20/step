#ifndef CAT_H
#define CAT_H
#include "animal.h"

class Cat : public Animal
{
public:
    Cat();
    void movement() override;
    void voice() override;
    void hunt();
};

#endif // CAT_H
