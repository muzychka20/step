#include <iostream>

int main() {
    // Завдання 1
    std::cout << "Завдання 1. Введіть 5 оцінок студента: ";
    double grade1, grade2, grade3, grade4, grade5;
    std::cin >> grade1 >> grade2 >> grade3 >> grade4 >> grade5;
    double averageGrade = (grade1 + grade2 + grade3 + grade4 + grade5) / 5;
    if (averageGrade >= 4) {
        std::cout << "Студент допущений до іспиту" << std::endl;
    }
    else {
        std::cout << "Студент не допущений до іспиту" << std::endl;
    }

    // Завдання 2
    std::cout << "Завдання 2. Введіть число: ";
    int number;
    std::cin >> number;
    if (number % 2 == 0) {
        std::cout << "Число парне, результат множення на 3: " << number * 3 << std::endl;
    }
    else {
        std::cout << "Число непарне, результат ділення на 2: " << number / 2 << std::endl;
    }

    // Завдання 3
    std::cout << "Завдання 3. Введіть два числа: ";
    double num1, num2;
    std::cin >> num1 >> num2;
    char operation;
    std::cout << "Виберіть арифметичну операцію (+, -, *, /): ";
    std::cin >> operation;
    double result;
    switch (operation) {
    case '+':
        result = num1 + num2;
        break;
    case '-':
        result = num1 - num2;
        break;
    case '*':
        result = num1 * num2;
        break;
    case '/':
        if (num2 != 0) {
            result = num1 / num2;
        }
        else {
            std::cout << "Помилка: ділення на нуль" << std::endl;
            return 1;
        }
        break;
    default:
        std::cout << "Помилка: невірна операція" << std::endl;
        return 1;
    }
    std::cout << "Результат: " << result << std::endl;

    return 0;
}




//Завдання 1. Користувач з клавіатури вводить 5 оцінок
//студента.Визначити, чи допущений студент до іспиту.
//Студент отримує допуск, якщо його середній бал 4 і вище.
//Завдання 2. Користувач вводить з клавіатури число.Якщо
//воно парне, помножити його на три, інакше — поділити
//на два.Результат вивести на екран.
//Завдання 3. Написати програму - калькулятор.Користувач
//вводить два числа і вибирає арифметичну дію.Вивести
//на екран результат.