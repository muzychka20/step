// Задание 5: Система управления персоналом
// Задача : Создайте базовый класс Employee, который содержит информацию о сотруднике, включая имя, должность и зарплату.
// Реализуйте производные классы Manager и Intern.
// Manager должен включать методы для управления подчинёнными и бонусной системы,
// тогда как Intern должен содержать данные о периоде стажировки и наставнике.

#include <iostream>
#include "Intern.h"
#include "Manager.h"

int main()
{
    Manager manager;
    manager.name = "Sam";
    manager.position = "manager";
    manager.salary = 2000;

    manager.showInfoEmployee();
    manager.managmentOfSubordinates();
    manager.managmentOfBonusSystem();

    cout << endl;

    Intern intern;
    intern.name = "Kate";
    intern.position = "intern";
    intern.salary = 1000;
    intern.mentor = "Sam";
    intern.period = "12.04.2023 - 12.07.2023";

    intern.showInfoIntern();

    return 0;
}