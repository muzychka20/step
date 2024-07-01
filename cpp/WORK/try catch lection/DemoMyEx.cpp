// DemoMyEx.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
using namespace std;

int divide(int numerator, int denominator) {
    if (denominator == 0) {
        throw std::invalid_argument("Знаменатель не может быть равен нулю");
    }
    return numerator / denominator;
}

void setAge(int age) {
    if (age < 0) {
        throw invalid_argument("Возраст не может быть отрицательным");
    }
}


int main()
{
    setlocale(LC_ALL, "Russian");
    std::cout << "Hello World!\n";

    try {
        // Код, который может сгенерировать исключение
        int result = divide(10, 0);  // Предполагаем, что функция divide может выбросить исключение
    }
    catch (const std::invalid_argument& e) {
        std::cout << "Caught an exception: " << e.what() << std::endl;
    }


}

