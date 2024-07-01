#include <iostream>
#include <string>

struct Person {
    std::string name;
};

struct Student {
    std::string name;
    int year;
};

struct Driver {
    std::string name;
    std::string licenseNumber;
};


template <typename T>
void printName(T obj) {
    std::cout << "Name: " << obj.name << std::endl;
}


int main() {
    Person person = { "Alice" };
    Student student = { "Bob", 2 };
    Driver driver = { "Charlie", "123456" };

    printName(person);
    printName(student);
    printName(driver);

    return 0;
}

