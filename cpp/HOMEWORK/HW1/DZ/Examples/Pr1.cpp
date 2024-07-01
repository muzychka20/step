#include <iostream>

int main() {
    // Завдання 1
    double num1, num2;
    std::cout << "Завдання 1. Введіть два числа: ";
    std::cin >> num1 >> num2;
    double sum1 = num1 + num2;
    double product1 = num1 * num2;
    double average1 = (num1 + num2) / 2;
    std::cout << "Сума: " << sum1 << std::endl;
    std::cout << "Добуток: " << product1 << std::endl;
    std::cout << "Середнє арифметичне: " << average1 << std::endl;

    // Завдання 2
    double num3, num4, num5;
    std::cout << "Завдання 2. Введіть три числа: ";
    std::cin >> num3 >> num4 >> num5;
    double sum2 = num3 + num4 + num5;
    double product2 = num3 * num4 * num5;
    double average2 = (num3 + num4 + num5) / 3;
    std::cout << "Сума: " << sum2 << std::endl;
    std::cout << "Добуток: " << product2 << std::endl;
    std::cout << "Середнє арифметичне: " << average2 << std::endl;

    // Завдання 3
    double price, quantity, discount;
    std::cout << "Завдання 3. Введіть вартість одного ноутбука, їхню кількість і відсоток знижки: ";
    std::cin >> price >> quantity >> discount;
    double totalAmount = price * quantity * (1 - discount / 100);
    std::cout << "Загальна сума замовлення: " << totalAmount << std::endl;

    // Завдання 4
    double sales;
    std::cout << "Завдання 4. Введіть загальну суму угод менеджера за місяць: ";
    std::cin >> sales;
    double salary = 100 + 0.05 * sales;
    std::cout << "Підсумкова зарплата менеджера: " << salary << std::endl;

    // Завдання 5
    double fileSizeGB, internetSpeedBPS;
    std::cout << "Завдання 5. Введіть розмір файлу в гігабайтах і швидкість інтернет-з’єднання в бітах на секунду: ";
    std::cin >> fileSizeGB >> internetSpeedBPS;
    double fileSizeBits = fileSizeGB * 8 * 1024 * 1024 * 1024; // Переводимо гігабайти в біти
    double downloadTimeSeconds = fileSizeBits / internetSpeedBPS;
    int hours = downloadTimeSeconds / 3600;
    int minutes = (downloadTimeSeconds - hours * 3600) / 60;
    int seconds = downloadTimeSeconds - hours * 3600 - minutes * 60;
    std::cout << "Час завантаження файлу: " << hours << " годин " << minutes << " хвилин " << seconds << " секунд" << std::endl;

    return 0;
}



//Завдання 1. Користувач вводить з клавіатури два числа.
//Порахувати їхню суму, добуток і середнє арифметичне.
//Завдання 2. Користувач вводить з клавіатури три числа.
//Порахувати їхню суму, добуток і середнє арифметичне.
//Завдання 3. Користувач вводить з клавіатури вартість
//одного ноутбука, їхню кількість і відсоток знижки.Порахувати загальну суму замовлення.
//Завдання 4. Зарплата менеджера — 100$ + 5 % від продажів.Користувач вводить з клавіатури загальну суму угод
//менеджера за місяць.Порахувати підсумкову зарплату
//менеджера.
//Завдання 5. Користувач вводить з клавіатури розмір одного файлу в гігабайтах і швидкість інтернет - з’єднання
//в бітах на секунду.Порахувати, за скільки годин, хвилин
//і секунд завантажиться файл.
