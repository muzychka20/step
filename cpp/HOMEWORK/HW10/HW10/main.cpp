#include <iostream>
#include "Date.hpp"
#include "Password.hpp"
#include "Event.hpp"
#include "Participant.hpp"

using namespace std;

//Задание 2 : Безопасное деление
//Задача : Напишите функцию для безопасного деления двух чисел, которая возвращает результат деления.Если делитель равен нулю, функция должна генерировать исключение runtime_error с соответствующим сообщением об ошибке.Проверьте работу функции в main, обрабатывая возможное исключение.
template <typename T>
T divideNumbers(T a, T b) {
    try {
        if (!b)
            throw runtime_error("Zero division!");
        return a / b;
    } catch(const runtime_error& error) {
        cerr << error.what() << endl;
        return -1;
    }
}


int main() {
    
    // 1
    cout << "--------------------------\n";
    Date* date = new Date("23.13.2034");
    if (date->validDate()) {
        cout << "Date is valid!\n";
    }    

    
    // 2
    cout << "--------------------------\n";
    cout << divideNumbers<int>(4, 0) << endl;


    // 3
    cout << "--------------------------\n";
    Password* password = new Password("QQQQQQQQQQqw12!");
    if (password->validPassword()) {
        cout << "Password is valid\n";
    }
    
    
    // 4
    cout << "--------------------------\n";
    Event* event = new Event();
    Participant p1(25, "1234567890");
    Participant p2(17, "0987654321");
    Participant p3(30, "1234567890");
    
    event->registerParticipant(&p1);
    event->registerParticipant(&p2);
    event->registerParticipant(&p3);
    
    return 0;
}
