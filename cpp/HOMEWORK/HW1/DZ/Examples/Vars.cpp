#include <iostream> // Подключаем библиотеку для ввода-вывода
#include <locale> 

int main() {

    setlocale(LC_ALL, "Russian"); // Устанавливаем локаль для поддержки кириллицы
    // Объявление переменных различных типов
    int integerNumber = 10; // Целочисленный тип
    double floatingPointNumber = 3.14; // Вещественный тип с плавающей точкой
    char character = 'A'; // Символьный тип
    bool booleanValue = true; // Булевый тип

    // Вывод переменных в консоль
    std::cout << "Целое число: " << integerNumber << std::endl;
    std::cout << "Число с плавающей точкой: " << floatingPointNumber << std::endl;
    std::cout << "Символ: " << character << std::endl;
    std::cout << "Булево значение: " << (booleanValue ? "true" : "false") << std::endl;

    // Примеры использования операторов
    int sum = integerNumber + 5; // Арифметический оператор (сложение)
    bool isGreater = floatingPointNumber > 2.0; // Оператор сравнения (больше)
    integerNumber += 1; // Оператор присваивания с операцией (инкремент)

    // Условный оператор
    if (isGreater) {
        std::cout << "Число с плавающей точкой больше 2.0" << std::endl;
    }

    // Цикл с предусловием
    while (integerNumber < 15) {
        std::cout << "Целое число сейчас равно: " << integerNumber << std::endl;
        integerNumber++; // Инкрементируем integerNumber
    }

    return 0; // Возвращаем 0 из функции main()
}
