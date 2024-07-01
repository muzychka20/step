#include <iostream>
#include <thread>

void displayNumber(int n) {
    std::cout << "Number: " << n << std::endl;  // Вывод переданного числа
}

int main() {
    std::thread t1(displayNumber, 10);  // Создание потока с передачей параметра
    t1.join();  // Ожидание завершения потока
    return 0;
}
