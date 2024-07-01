#include <iostream>
#include "Person.h"
#include "Student.h"
#include "Driver.h"

int main()
{
    Person* person = new Person("Sam", "Vern");
    person->showInfo();

    std::cout << std::endl;

    Student* student = new Student("Kate", "Lee", "PZ-21-1d");
    student->showInfo();
    
    std::cout << std::endl; student->showGroup();

    std::cout << std::endl;

    Driver* driver = new Driver("John", "Adam", "B", 20);
    driver->showInfo();
    
    std::cout << std::endl; driver->showLicenseCategory();

    std::cout << std::endl;

    return 0;
}