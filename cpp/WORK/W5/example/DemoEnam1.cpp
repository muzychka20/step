#include <iostream>
#include <string>
using namespace std;

enum Color {
    RED,
    GREEN,
    BLUE
};


//Color myColor = RED;
//
//if (myColor == RED) {
//    std::cout << "The color is red." << std::endl;
//}


// Определение перечисления для статуса задачи
enum TaskStatus {
    TODO,
    IN_PROGRESS,
    DONE
};

// Определение структуры для задачи
struct Task {
    string name;
    TaskStatus status;
};

void processTask(Task& task) {
    switch (task.status) {
    case TODO:
        std::cout << "Starting task: " << task.name << std::endl;
        task.status = IN_PROGRESS;
        break;
    case IN_PROGRESS:
        std::cout << "Completing task: " << task.name << std::endl;
        task.status = DONE;
        break;
    case DONE:
        std::cout << "Task already completed: " << task.name << std::endl;
        break;
    }
}

int main() {
    Task myTask = { "Fix bug #42", TODO };

    processTask(myTask); // должен начать задачу
    std::cout << "Task status is now: " << myTask.status << std::endl;

    processTask(myTask); // должен завершить задачу
    std::cout << "Task status is now: " << myTask.status << std::endl;

    processTask(myTask); // задача уже завершена
    std::cout << "Task status is now: " << myTask.status << std::endl;

    return 0;
}

//Задание 1: Основы enum
//Цель : Создать перечисление Color с тремя цветами : RED, GREEN, BLUE.
//
//Определите перечисление Color.
//Напишите функцию, которая принимает Color и выводит соответствующее название цвета на экран.
//Задание 2 : Применение enum в условных операторах
//Цель : Использовать enum Color для управления потоком выполнения программы.
//
//Расширьте перечисление Color, добавив дополнительные цвета.
//Напишите функцию, которая изменяет переданный цвет на следующий в перечислении(например, с RED на GREEN) и возвращает новое значение.
//В main, продемонстрируйте изменение цвета и его вывод.
//Задание 3 : enum с нестандартными значениями
//Цель : Определить перечисление Weekday с днями недели, начиная с понедельника, сопоставив дням недели числовые значения(1 для понедельника и т.д.).
//
//Создайте перечисление Weekday с днями недели.
//Напишите функцию, которая по числовому значению дня недели возвращает соответствующее имя дня.
//В main, продемонстрируйте использование этой функции для нескольких значений.
//Задание 4 : enum class
//Цель : Создать перечисление с классом TrafficLight для управления светофором, где каждый цвет(красный, жёлтый, зелёный) соответствует определённому состоянию.
//
//Определите enum class TrafficLight с тремя состояниями : RED, YELLOW, GREEN.
//Напишите функцию, которая принимает TrafficLight и возвращает рекомендацию для водителя(например, "Stop" для красного).
//В main, продемонстрируйте использование этой функции для каждого состояния светофора.
//Задание 5 : Интеграция enum со структурами
//Цель : Создать систему для управления учебными курсами, используя enum для статусов курса(например, ACTIVE, COMPLETED, CANCELED) и структуру для представления курса.
//
//Определите enum для статуса курса.
//Создайте структуру Course с полями названия курса, количества учеников и статуса.
//Напишите функции для изменения статуса курса и для вывода информации о курсе.
//В main, создайте несколько курсов с различными статусами и продемонстрируйте функциональность вашей системы.
