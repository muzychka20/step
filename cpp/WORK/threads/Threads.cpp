#include <iostream>
#include <thread>
using namespace std;

void printMessage() {
    cout << "Hello from thread!" << endl;  // Вывод сообщения из потока
}

int main() {
    thread t1(printMessage);  // Создание потока, который запускает функцию printMessage
    t1.join();  // Ожидание завершения потока перед выходом из main
    return 0;
}
