#include <iostream>

using namespace std;

void validateName(string name) {
    if (name.length() < 3) {
        throw invalid_argument("Name lenght >= 3");
    }
    if (name.length() > 50) {
        throw invalid_argument("Name lenght <= 50");
    }    
}

void validateAge(int age) {
    if (age < 18) {
        throw logic_error("Age >= 18");
    }
    if (age > 120) {
        throw logic_error("Age <= 120");
    }
}

void validateSecond(string second) {
    if (second.length() < 3) {
        throw invalid_argument("Second lenght >= 3");
    }
    if (second.length() > 50) {
        throw invalid_argument("Second lenght <= 50");
    }
}

void validateLast(string last) {
    if (last.length() < 3) {
        throw invalid_argument("Last lenght >= 3");
    }
    if (last.length() > 50) {
        throw invalid_argument("Last lenght <= 50");
    }
}

void validateUser(string name, int age, string second, string last) {
    validateName(name);
    validateAge(age);
    validateSecond(second);
    validateLast(last);
    cout << "Registered successfully\n";
}


void level3(string name, int age, string second, string last) {
    try {
        validateUser(name, age, second, last);
    }
    catch (const invalid_argument& e) {
        cerr << "(invalid argument level3) " << e.what() << endl;
    }   
}

void level2(string name, int age, string second, string last) {    
    cout << "level2: " << name << " " << age << " " << second << " " << last << endl;
    level3(name, age, second, last);
}

void level1(string name, int age, string second, string last) {
    cout << "level1: " << name << " " << age << " " << second << " " << last << endl;
    level2(name, age, second, last);
}

int main()
{
    string name, second, last; int age;

    try {
        cout << "Name: "; cin >> name;
        cout << "Age: "; cin >> age;
        cout << "Second: "; cin >> second;
        cout << "Last: "; cin >> last;
        level1(name, age, second, last);        
    }
    catch (const logic_error& e) {
        cerr << "(logic main) " << e.what() << endl;
    }

    return 0;
}