#include <iostream>

using namespace std;

class Car {
private:
    double power;

public:
    string brand;
    string model;
    int year;
    int run;

    Car(string b, string m, int y, int r) : brand(b), model(m), year(y), run(r), power(1.8) {};
    /*  brand = b;
        model = m;
        year = y;
        run = r;
        power = 1.8;
    }*/

    void displayInfo() {
        cout << "Brand: " << brand << endl;
        cout << "Model: " << model << endl;
        cout << "Year: " << year << endl;
    }

    void displayRun() {
        cout << "Run: " << run << endl;
    }

    void setPower(double power) {
        this->power = power;
    }

    double getPower() {
        return this->power;
    }

    void displayPower() {
        cout << "Power: " << this->getPower() << endl;        
    }

    void displayPrice() {
        cout << "Price: " << power * run << endl;
    }
};

class Book {
public:
    string title;
    string author;
    int year;
    
    Book(string t, string a, int y)
    {
        this->title = t;
        this->author = a;
        this->year = y;
    }

    void displayInfo() 
    {
        cout << "Title: " << this->title << endl;
        cout << "Author: " << this->author << endl;
        cout << "Year: " << this->year << endl;
    }
};

int main()
{
    Car car("Skoda", "Octavia", 2024, 200000);

    car.displayInfo();
    car.displayRun();
    car.displayPower();
    
    cout << endl;

    car.setPower(2.5);

    car.displayInfo();
    car.displayPower();    
    car.displayPrice();

    cout << endl;

    Book* book = new Book("Inferno", "Dan Brown", 2018);
    book->displayInfo();

    return 0;
}