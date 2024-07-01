#include <iostream>
#include <string> // Подключаем библиотеку для работы со строками

int main() {
    // Целочисленные типы данных
    int integerNumber = 10;
    std::cout << "Целочисленное число: " << integerNumber << std::endl;

    // Вещественные типы данных
    double doubleNumber = 3.14;
    std::cout << "Вещественное число: " << doubleNumber << std::endl;

    // Символьный тип данных
    char character = 'A';
    std::cout << "Символ: " << character << std::endl;

    // Булевый тип данных
    bool booleanValue = true;
    std::cout << "Булевое значение: " << (booleanValue ? "true" : "false") << std::endl;

 
    // Строковый тип данных
    std::string myString = "Hello, world!";
    std::cout << "Строка: " << myString << std::endl;

    // Арифметические операции
    int sum = integerNumber + 5;
    std::cout << "Сумма: " << sum << std::endl;

    double product = doubleNumber * 2;
    std::cout << "Произведение: " << product << std::endl;

    // Логические операции
    bool isEqual = integerNumber == doubleNumber;
    std::cout << "Числа равны: " << (isEqual ? "true" : "false") << std::endl;

    // Условный оператор
    if (integerNumber > 5) 
    {
        std::cout << "Целочисленное число больше 5" << std::endl;
    }
    else 
    {
        std::cout << "Целочисленное число не больше 5" << std::endl;
    }

    return 0;
}
