#include <iostream>
#include <thread>
#include <chrono>  // Библиотека для работы с временем

void longRunningTask() {
    for (int i = 0; i < 5; ++i) {
        std::cout << "Thread running " << i << std::endl;  // Вывод текущего шага выполнения
        std::this_thread::sleep_for(std::chrono::seconds(1));  // Приостановка потока на 1 секунду
    }
}

int main() {
    std::thread t1(longRunningTask);  // Запуск длительной задачи в потоке
    t1.join();  // Ожидание завершения потока
    return 0;
}
