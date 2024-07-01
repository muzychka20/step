#include <vector>
#include <iostream>
#include <stdexcept>

using namespace std;

void testFunction(int index, int size) {
    if (size <= 0) {
        throw length_error("Размер массива должен быть больше нуля");
    }
    vector<int> vec(size);
    if (index < 0 || index >= size) {
        throw out_of_range("Индекс вне диапазона вектора");
    }
    cout << "Доступ к элементу: " << vec[index] << endl;
}

int main() {
    setlocale(LC_ALL, "Russian");
    try {
        testFunction(5, 4);
    }
    catch (const length_error& le) {
        cerr << "Ошибка: " << le.what() << endl;
    }
    catch (const out_of_range& ore) {
        cerr << "Ошибка диапазона: " << ore.what() << endl;
    }
    catch (const exception& e) {
        cerr << "Произошла ошибка: " << e.what() << endl;
    }
    return 0;
}
