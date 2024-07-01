#include <iostream>
#include <locale> 

int main() {
    setlocale(LC_ALL, "Russian"); // Устанавливаем локаль для поддержки кириллицы
    // Цикл for для вывода чисел от 1 до 5
    std::cout << "Цикл for от 1 до 5:" << std::endl;
    for (int i = 1; i <= 5; i++) {
        std::cout << i << " ";
    }
    std::cout << std::endl; // Переход на новую строку после завершения цикла

    // Цикл for для уменьшения значения переменной от 5 до 1
    std::cout << "Обратный цикл for от 5 до 1:" << std::endl;
    for (int i = 5; i >= 1; i--) {
        std::cout << i << " ";
    }
    std::cout << std::endl;

    // Использование цикла for для обхода массива
    int arr[] = { 10, 20, 30, 40, 50 };
    std::cout << "Элементы массива:" << std::endl;
    for (int i = 0; i < 5; i++) {
        std::cout << "arr[" << i << "] = " << arr[i] << std::endl;
    }

    // Цикл for с несколькими переменными
    std::cout << "Цикл for с несколькими переменными:" << std::endl;
    for (int i = 1, j = 5; i <= 5; i++, j--) {
        std::cout << "i = " << i << ", j = " << j << std::endl;
    }

    // Диапазонный цикл for для работы с массивами (C++11 и выше)
    std::cout << "Диапазонный цикл for для массива:" << std::endl;
    for (int x : arr) {
        std::cout << x << " ";
    }
    std::cout << std::endl;

    return 0;
}
