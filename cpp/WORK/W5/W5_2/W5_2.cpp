#include <iostream>
#include <string>
#include <vector>

using namespace std;

//Задача 3 : Вложенные структуры
//Цель : Создать структуру Person с вложенной структурой DateOfBirth.
//
//Определите структуру DateOfBirth с полями : day, month, и year.
//Определите структуру Person с полями : name(имя, строка) и dob(дата рождения, DateOfBirth).
//Напишите функцию, которая принимает Person и выводит его имя и дату рождения.

struct DateOfBirth {
    int day;
    string month;
    int year;
};

struct Person {
    string name;
    DateOfBirth dob;
};

void PrintPerson(Person person)
{
    cout << "Person" << endl;
    cout << "Name: " << person.name << endl;
    cout << "Date of Birth: " << person.dob.day << " " << person.dob.month << " " << person.dob.year << endl;
    cout << endl;
}

//Задача 4 : Динамическое управление структурами
//Цель : Работа со списком структур, динамически изменяемым во время выполнения программы.
//
//Создайте динамический массив структур Person.
//Напишите функции для добавления нового Person в массив и вывода всех людей в массиве.


void PrintPersons(vector<Person> array)
{
    for (int i = 0; i < array.size(); i++)    
        PrintPerson(array[i]);    
}

void AddPerson(vector<Person> &array, Person p)
{
    array.push_back(p);
}

int main()
{
    int size = 2;
    Person person = { "John", {15, "april", 2000} };
    PrintPerson(person);

    vector<Person> arrayPerson;
    arrayPerson.push_back({ "Sam", {20, "february", 2001} });
    arrayPerson.push_back({ "Kate", {11, "may", 2003 } });
        
    AddPerson(arrayPerson, person);
    PrintPersons(arrayPerson);

    return 0;
}