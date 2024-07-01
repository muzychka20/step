#include <iostream>
#include <string>
using namespace std;

// Функция устанавливает возраст, генерирует исключение при недопустимом значении
void setAge(int age) {
    if (age < 0) {
        throw invalid_argument("Возраст не может быть отрицательным");
    }
    cout << "Возраст установлен: " << age << endl;
}

int main() {
    try {
        setAge(-5);
    }
    catch (const invalid_argument& e) {
        cerr << "Ошибка: " << e.what() << endl;
    }
    return 0;
}


#include <vector>
#include <iostream>
#include <stdexcept>

// Функция получает доступ к элементу вектора и генерирует исключение при выходе за границы
void accessElement(const vector<int>& vec, int index) {
    if (index < 0 || index >= vec.size()) {
        throw out_of_range("Индекс за пределами диапазона вектора");
    }
    cout << "Значение элемента: " << vec[index] << endl;
}

int main() {
    vector<int> myVector = { 1, 2, 3 };
    try {
        accessElement(myVector, 3);
    }
    catch (const out_of_range& e) {
        cerr << "Ошибка: " << e.what() << endl;
    }
    return 0;
}


#include <stdexcept>
#include <iostream>

// Функция деления двух чисел, генерирует исключение при делении на ноль
int divide(int numerator, int denominator) {
    if (denominator == 0) {
        throw runtime_error("Деление на ноль");
    }
    return numerator / denominator;
}

int main() {
    try {
        cout << "Результат деления: " << divide(10, 0) << endl;
    }
    catch (const runtime_error& e) {
        cerr << "Ошибка: " << e.what() << endl;
    }
    return 0;
}

