#include <iostream>
#include <string>

using namespace std;

template <typename T>
T sum(T a, T b)
{
    return a + b;
}

template <typename T>
T mult(T a, T b)
{
    return a * b;
}

template <typename T>
T subtract(T a, T b)
{
    return a - b;
}

// написать шаблон функции которая будет принимать стуктуру в которой есть поле имя.и выводит на экран

struct Person {
    string name;
};

template <typename T>
void PrintName(T a)
{
    cout << a.name;
}

int main()
{
    cout << sum<int>(3, 4) << endl;
    cout << sum<double>(3.4, 4.8) << endl;
    cout << endl;
    cout << mult<int>(3, 4) << endl;
    cout << mult<double>(3.4, 4.8) << endl;
    cout << endl;
    cout << subtract<int>(3, 4) << endl;
    cout << subtract<double>(3.4, 4.8) << endl;
    cout << endl;

    Person p = { "Sam" };
    PrintName<Person>(p);

    return 0;
}