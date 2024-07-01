#include <iostream>
using namespace std;

// Определение шаблона функции
template <typename T>
T sum(T a, T b) {
    return a + b;
}


int main() {
    // Использование шаблонной функции для int
    int intResult = sum<int>(5, 3);
    cout << "Sum of 5 and 3 is " << intResult << endl;

    // Использование шаблонной функции для double
    double doubleResult = sum<double>(2.5, 3.5);
    cout << "Sum of 2.5 and 3.5 is " << doubleResult << endl;

    return 0;
}
