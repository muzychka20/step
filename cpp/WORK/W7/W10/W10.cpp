#include <iostream>
using namespace std;

// Определение класса Node (узел)
class Node {
public:
    int data;  // Данные, хранящиеся в узле
    Node* next;  // Указатель на следующий узел в списке

    // Конструктор для инициализации узла
    Node(int data) : data(data), next(nullptr) {}
};

// Класс для управления односвязным списком
class SinglyLinkedList {
private:
    Node* head;  // Указатель на первый узел списка

public:
    // Конструктор
    SinglyLinkedList() : head(nullptr) {}

    // Деструктор для очистки памяти
    ~SinglyLinkedList() {
        Node* current = head;
        while (current != nullptr) {
            Node* next = current->next;
            delete current;
            current = next;
        }
    }

    // Функция для добавления узла в начало списка
    void pushFront(int data) {
        Node* newNode = new Node(data);
        newNode->next = head;
        head = newNode;
    }

    // Функция для удаления узла из начала списка
    void popFront() {
        if (head == nullptr) return;
        Node* temp = head;
        head = head->next;
        delete temp;
    }

    void insert(int index, int data) {
        // Если нужно вставить в начало списка, используем уже существующий метод pushFront
        if (index == 0) {
            pushFront(data);
            return;
        }
        // Начинаем с первого узла списка
        Node* current = head;
        // Проходим по списку до узла, который находится перед нужной позицией для вставки
        for (int i = 0; current != nullptr && i < index - 1; i++) {
            current = current->next;
        }
        // Если после цикла current равен nullptr, значит индекс выходит за пределы списка
        if (current == nullptr) {
            cout << "Index out of bounds" << endl;
            return;
        }
        // Создаем новый узел с данными
        Node* newNode = new Node(data);
        // Новый узел указывает на следующий узел после current
        newNode->next = current->next;
        // Текущий узел теперь указывает на новый узел
        current->next = newNode;
    }


    void remove(int index) {
        // Если список пуст, просто выходим из функции
        if (head == nullptr) return;
        // Если нужно удалить первый элемент, используем уже существующий метод popFront
        if (index == 0) {
            popFront();
            return;
        }
        // Начинаем с первого узла
        Node* current = head;
        // prev будет указывать на узел перед current
        Node* prev = nullptr;
        // Проходим по списку до узла, который нужно удалить
        for (int i = 0; current != nullptr && i < index; i++) {
            prev = current; // Сохраняем текущий узел как предыдущий
            current = current->next; // Перемещаемся к следующему узлу
        }
        // Если current равен nullptr, значит индекс выходит за пределы списка
        if (current == nullptr) {
            cout << "Index out of bounds" << endl;
            return;
        }
        // Устанавливаем у prev ссылку на узел после current, тем самым исключая current из списка
        prev->next = current->next;
        // Освобождаем память, занимаемую удаляемым узлом
        delete current;
    }


    void print() {
        Node* current = head;
        while (current != nullptr) {
            cout << current->data << " -> ";
            current = current->next;
        }
        cout << "nullptr" << endl;
    }
};

int main() {
    SinglyLinkedList list;
    
    for (int i = 10; i >= 1; i--)
        list.pushFront(i);    
    cout << "List after inserting 1-10: ";
    list.print();

    list.insert(2, 25);
    cout << "List after inserting 25 at index 2: ";
    list.print();
    
    list.remove(2);
    cout << "List after removing the element at index 2: ";
    list.print();

    list.insert(10, 100);
    cout << "List after inserting 100 at index 10: ";
    list.print();

    return 0;
}
