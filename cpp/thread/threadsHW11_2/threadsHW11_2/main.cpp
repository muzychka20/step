#include <iostream>
#include <thread>
#include <chrono>
#include <vector>
#include <mutex>

using namespace std;

// Задача 2: Многопоточный таймер
// Цель : Создать многопоточное приложение с таймером, где каждый поток начинает отсчёт
// заданного времени(разное для каждого потока),
// выводит уведомление при достижении этого времени и завершает свою работу.

void countdown(int threadIndex, int seconds, mutex* mtx) {
    for (int i = seconds; i > 0; i--) {
        {
            lock_guard<mutex> guard(*mtx);
            cout << "Thread " << threadIndex << ": " << i << endl;
            this_thread::sleep_for(chrono::seconds(1));
        }
    }
    {
        lock_guard<mutex> guard(*mtx);
        cout << "Thread " << threadIndex << " finished!\n";
    }
}

int main()
{
    vector<thread> threads;
    vector<int> durations = {5, 3, 7};
    mutex mtx;
    
    for (int i = 0; i < durations.size(); i++) {
        threads.push_back(thread(countdown, i, durations[i], &mtx));
    }
    
    for (auto &thread : threads) {
          thread.join();
    }

    return 0;
}
