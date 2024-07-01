#include <iostream>
#include <thread>

void printMessage() {
    std::cout << "Hello from thread! " << std::endl;
}

int main() {
    std::thread t1(printMessage);  // Первый поток
    std::thread t2(printMessage);  // Второй поток

    t1.join();  // Ожидаем завершение первого потока
    t2.join();  // Ожидаем завершение второго потока
    return 0;
}
