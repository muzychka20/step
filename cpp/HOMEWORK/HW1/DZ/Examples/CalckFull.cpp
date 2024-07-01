#include <iostream>

int main() {
    char operation;
    double num1, num2;

    // Ввод первого числа
    std::cout << "Введите первое число: ";
    std::cin >> num1;

    // Ввод операции
    std::cout << "Введите операцию (+, -, *, /): ";
    std::cin >> operation;

    // Ввод второго числа
    std::cout << "Введите второе число: ";
    std::cin >> num2;

    double result;

    // Выполнение операции и вывод результата
    switch (operation) {
    case '+':
        result = num1 + num2;
        std::cout << "Результат: " << result << std::endl;
        break;
    case '-':
        result = num1 - num2;
        std::cout << "Результат: " << result << std::endl;
        break;
    case '*':
        result = num1 * num2;
        std::cout << "Результат: " << result << std::endl;
        break;
    case '/':
        if (num2 != 0) {
            result = num1 / num2;
            std::cout << "Результат: " << result << std::endl;
        }
        else {
            std::cout << "Ошибка: деление на ноль!" << std::endl;
        }
        break;
    default:
        std::cout << "Ошибка: неправильная операция!" << std::endl;
        break;
    }

    return 0;
}
