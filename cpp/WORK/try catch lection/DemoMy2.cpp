#include <iostream>
#include <stdexcept>
#include <string>
using namespace std;

// Определение пользовательского класса исключения
class DataValidationException : public std::exception {
private:
    std::string message;

public:
    DataValidationException(const std::string& msg) : message(msg) {}

    const char* what() const noexcept override {
        return message.c_str();
    }
};

// Функция для валидации возраста пользователя
void validateAge(int age) {
    if (age < 0 || age > 150) {
        throw DataValidationException("Возраст должен быть в пределах от 0 до 150 лет.");
    }
    std::cout << "Возраст валиден: " << age << std::endl;
}

int main() {
    setlocale(LC_ALL, "Russian");
    try {
        validateAge(-5);  // Попытка установить неверный возраст
    }
    catch (const DataValidationException& e) {
        std::cerr << "Ошибка валидации: " << e.what() << std::endl;
    }
    catch (const std::exception& e) {
        std::cerr << "Стандартная ошибка: " << e.what() << std::endl;
    }
    return 0;
}

//Определение исключения : DataValidationException определяется как производный от std::exception, 
// что позволяет ему взаимодействовать с другими частями стандартной библиотеки C++.
//Конструктор : Принимает строку, которая сохраняется в частном поле message и возвращается при вызове what(), 
// которое переопределено для предоставления сообщения об ошибке.
//Функция validateAge : Проверяет, находится ли возраст в допустимых пределах.
// Если нет, генерирует DataValidationException с соответствующим сообщением.
//Блок try - catch в main : Пытается вызвать validateAge с некорректным значением.
// При генерации DataValidationException перехватывает это исключение и выводит сообщение об ошибке.
// Также предусмотрен дополнительный перехват других возможных стандартных исключений.

