#include <iostream>
#include <string>
using namespace std;

// Структура Person для хранения информации о человеке
struct Person {
    string name;
    int age;
};

// Структура Date для представления даты
struct Date {
    int day;
    int month;
    int year;
};

// Структура Product для учета товара
struct Product {
    string name;
    double price;
    int quantity;
};

// Функция для вывода информации о человеке
void printPerson(const Person& person) {
    cout << "Name: " << person.name << ", Age: " << person.age << endl;
}

// Функция для вывода даты
void printDate(const Date& date) {
    cout << "Date: " << date.day << "/" << date.month << "/" << date.year << endl;
}

// Функция для вывода информации о продукте
void printProduct(const Product& product) {
    cout << "Product Name: " << product.name
        << ", Price: $" << product.price
        << ", Quantity: " << product.quantity << endl;
}

int main() {
    Person person = { "John Doe", 30 };
    Date birthdate = { 1, 1, 1990 };
    Product laptop = { "Laptop", 999.99, 10 };

    printPerson(person);
    printDate(birthdate);
    printProduct(laptop);

    return 0;
}
