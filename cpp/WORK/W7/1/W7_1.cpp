// «адание 1: –асширение класса Person
// «адача : ќпределите класс Person, который содержит базовые атрибуты, такие как им€ и возраст.
// «атем создайте класс Student, который наследуетс€ от Person и добавл€ет специфические атрибуты и методы,
// такие как номер студенческого билета и метод дл€ отображени€ полной информации о студенте.

#include <iostream>
#include "Student.h"
#include "Person.h"

int main()
{
    Student student;
    student.name = "Sam";
    student.age = 20;
    student.studentNumberID = 123;
    student.showStudentInfo();
    return 0;
}
