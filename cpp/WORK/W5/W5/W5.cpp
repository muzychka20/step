#include <iostream>
#include <string>

using namespace std;


struct Square1 {
    float a;
    float b;
    float c;
    float d;
};

struct Person {
    string name;
    string surname;
    int age;
};

struct Pupil {
    string name;
    string surname;
    int age;
    int classNumber;
};


struct Student {
    string name;
    string surname;
    int age;
    int course;
};

struct Teacher {
    string name;
    string surname;
    int age;
    string subject;
};

void PrintPupil(Pupil pupil)
{
    cout << "Name: " << pupil.name << endl;
    cout << "Surname: " << pupil.surname << endl;
    cout << "Age: " << pupil.age << endl;
    cout << "Class: " << pupil.classNumber << endl;
}

void PrintStudent(Student student)
{
    cout << "Name: " << student.name << endl;
    cout << "Surname: " << student.surname << endl;
    cout << "Age: " << student.age << endl;
    cout << "Course: " << student.course << endl;
}

void PrintTeacher(Teacher teacher)
{
    cout << "Name: " << teacher.name << endl;
    cout << "Surname: " << teacher.surname << endl;
    cout << "Age: " << teacher.age << endl;
    cout << "Subject: " << teacher.subject << endl;
}

float GetPOfSquare(Square1 square)
{
    return square.a + square.b + square.c + square.d;
}

float GetP(float a, float b, float c, float d)
{
    return a + b + c + d;
}

int main()
{
    Square1 sq = {1, 2, 3, 4};    
    cout << GetP(2, 3, 4, 5) << endl;
    cout << GetPOfSquare(sq) << endl;
    return 0;
}