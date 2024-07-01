#include <vector>
#include "animal.h"
#include "horse.h"
#include "cat.h"
#include "dog.h"

using namespace std;

int main()
{
    vector<Animal*> animals;
    animals.push_back(new Horse());
    animals.push_back(new Cat());
    animals.push_back(new Dog());

    for (auto el : animals) {
        el->movement();
        el->voice();
    }

    Animal* animal = new Animal();
    animal->movement();
    animal->voice();

    Horse* horse = new Horse();
    horse->plow();

    Dog* dog = new Dog();
    dog->defend();

    Cat* cat = new Cat();
    cat->hunt();

    return 0;
}
