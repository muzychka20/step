#include <iostream>
#include <string>

using namespace std;

//Задача 1: Определение и использование структуры
//Цель : Создать структуру Car для хранения информации об автомобиле.
//
//Определите структуру Car с полями : make(марка, строка), model(модель, строка) и year(год выпуска, целое число).
//Напишите функцию, которая принимает объект Car и выводит его данные.

struct Car {
	string make;
	string model;
	int year;
};

void PrintCar(Car car)
{
	cout << "Car" << endl;
	cout << "Make: " << car.make << endl;
	cout << "Model: " << car.model<< endl;
	cout << "Year: " << car.year << endl;
	cout << endl;
}

//Задача 2 : Работа со списком структур
//Цель : Создать массив структур Car и вывести информацию о каждом автомобиле.
//
//Определите массив из трёх автомобилей типа Car и инициализируйте его различными значениями.
//Напишите функцию, которая принимает массив автомобилей и их количество, затем выводит информацию о каждом автомобиле.

void PrintCars(Car arr[], int size)
{			
	for (int i = 0; i < size; i++)	
		PrintCar(arr[i]);	
}

int main()
{
	Car car = { "Skoda", "Octavia", 2024 };
	PrintCar(car);
	
	Car carArray[3];
	carArray[0] = { "Honda", "Civic", 2012 };
	carArray[1] = { "Toyota", "Camry", 2015 };
	carArray[2] = { "Volkswagen", "Passat", 2018 };
	PrintCars(carArray, sizeof(carArray) / sizeof(carArray[0]));

	return 0;
}