#include <iostream>
#include <thread>
#include <chrono>

void threadFunction(int threadNum) {
    // Длительность паузы увеличивается с номером потока
    int sleepTime = 1 + threadNum;

    // Приостанавливаем выполнение потока на заданное время
    std::this_thread::sleep_for(std::chrono::seconds(sleepTime));

    // Выводим номер потока и результат вычисления (квадрат номера потока)
    std::cout << "Thread " << threadNum << " slept for " << sleepTime << " seconds and calculated result: " << threadNum * threadNum << std::endl;
}

int main() {
    const int numThreads = 5;  // Количество потоков
    std::thread threads[numThreads];  // Массив потоков

    // Создаем и запускаем каждый поток
    for (int i = 0; i < numThreads; ++i) {
        threads[i] = std::thread(threadFunction, i + 1);
    }

    // Ожидаем завершения всех потоков
    for (int i = 0; i < numThreads; ++i) {
        threads[i].join();
    }

    return 0;
}
