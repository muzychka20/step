#include <iostream>
#include <vector>
#include <stdexcept>
#include <fstream>

using namespace std;

// Функция для проверки допустимого процентного значения
void setPercentage(int percent) {
    if (percent < 0 || percent > 100) {
        throw invalid_argument("Процент должен быть в пределах от 0 до 100");
    }
    cout << "Установленный процент: " << percent << endl;
}

// Функция для доступа к элементу вектора
void accessElement(const vector<int>& vec, int index) {
    if (index < 0 || index >= vec.size()) {
        throw out_of_range("Индекс вне допустимого диапазона вектора");
    }
    cout << "Значение элемента: " << vec[index] << endl;
}

// Функция для изменения размера строки
void resizeString(string& str, size_t newSize) {
    if (newSize > str.max_size()) {
        throw length_error("Запрошенный размер превышает максимально допустимый для строки");
    }
    str.resize(newSize);
    cout << "Новый размер строки: " << str.size() << endl;
}

// Функция для обработки файла
void processFile(const string& filename) {
    ifstream file(filename);
    if (!file) {
        throw runtime_error("Не удалось открыть файл");
    }
    cout << "Файл успешно открыт." << endl;
}

// Главная функция программы
int main() {
    setlocale(LC_ALL, "Russian");
    try {
        //setPercentage(110);
        //vector<int> vec = { 1, 2, 3 };
        //accessElement(vec, 2);
        string myString = "Пример строки";
        resizeString(myString, 1000);
        //processFile("example.txt");
    }
    catch (const invalid_argument& e) {
        cerr << "Invalid argument: " << e.what() << endl;
    }
    catch (const out_of_range& e) {
        cerr << "Out of range error: " << e.what() << endl;
    }
    catch (const length_error& e) {
        cerr << "Length error: " << e.what() << endl;
    }
    catch (const runtime_error& e) {
        cerr << "Runtime error: " << e.what() << endl;
    }
    catch (const exception& e) {
        cerr << "Other error: " << e.what() << endl;
    }

    return 0;
}
