// «адание 1: –асширение класса Person
// «адача : ќпределите класс Person, который содержит базовые атрибуты, такие как им€ и возраст.
// «атем создайте класс Student, который наследуетс€ от Person и добавл€ет специфические атрибуты и методы,
// такие как номер студенческого билета и метод дл€ отображени€ полной информации о студенте.

#include <iostream>
#include "Person.h"
#include "Student.h"
#include "Postgraduate.h"

int main()
{
    Student student("Sam", 20, 123);
    student.showStudentInfo();
    
    cout << endl;
    
    Postgraduate postgraduate("Kate", 25, 777, { "Git", "OOP" });
    postgraduate.showStudentInfo();
    postgraduate.showSubjects();

    return 0;
}