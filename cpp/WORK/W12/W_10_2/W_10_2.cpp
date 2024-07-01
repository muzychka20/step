#include <iostream>
#include <stdexcept>

using namespace std;

void level3() {
    throw runtime_error("Ошибка на уровне 3");
}

void level2() {
    level3();
}

void level1() {
    try {
        level2();
    }
    catch (const runtime_error& e) {
        cout << "Исключение перехвачено в level1: " << e.what() << endl;
        throw;  // Переброс исключения наверх по стеку
    }
}

int main() {
    setlocale(LC_ALL, "Russian");
    try {
        level1();
    }
    catch (const runtime_error& e) {
        cout << "Исключение перехвачено в main: " << e.what() << endl;
    }
    return 0;
}
