//В C++ стандартная библиотека предоставляет несколько функций, аналогичных stoi, которые позволяют преобразовывать строки в различные числовые типы.Все эти функции доступны в заголовочном файле <string> и обладают схожими с stoi возможностями и синтаксисом.Вот основные из них :
//
//stol и stoll :
//
//stol(string to long) : преобразует строку в long int.
//stoll(string to long long) : преобразует строку в long long int.
//Обе функции могут генерировать исключения std::invalid_argument и std::out_of_range, аналогично stoi.
//stoul и stoull :
//
//stoul(string to unsigned long) : преобразует строку в unsigned long.
//stoull(string to unsigned long long) : преобразует строку в unsigned long long.
//Эти функции также могут генерировать исключения при ошибочных входных данных.
//stof, stod, и stold :
//
//stof(string to float) : преобразует строку в float.
//stod(string to double) : преобразует строку в double.
//stold(string to long double) : преобразует строку в long double.
//Эти функции полезны для преобразования строк, содержащих десятичные числа, и могут также генерировать std::invalid_argument и std::out_of_range.


#include <iostream>
#include <string>
#include <exception>

int main() {
    try {
        std::string floatStr = "3.14159";
        float pi = std::stof(floatStr);
        std::cout << "Float: " << pi << std::endl;

        std::string intStr = "123456789012345";
        long long bigNum = std::stoll(intStr);
        std::cout << "Long Long: " << bigNum << std::endl;

        std::string invalidStr = "test";
        double invalidDouble = std::stod(invalidStr);  // Исключение std::invalid_argument
    }
    catch (const std::invalid_argument& e) {
        std::cerr << "Invalid argument: " << e.what() << std::endl;
    }
    catch (const std::out_of_range& e) {
        std::cerr << "Out of range: " << e.what() << std::endl;
    }
    return 0;
}
