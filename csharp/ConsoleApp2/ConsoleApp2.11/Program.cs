/*
Задание 4
Создайте класс Car, который будет представлять автомобиль.
Класс должен содержать закрытые поля: make(марка автомобиля), model(модель) и year(год выпуска).
Реализуйте свойства для доступа к этим полям. Добавьте конструктор для инициализации всех полей.
Создайте метод GetCarInfo, который возвращает строку с информацией об автомобиле.
*/

using System;

namespace ConsoleApp2._11
{
    class Program
    {
        class Car
        {
            private string make;
            public string Make
            {
                get { return make; }
                set { make = value; }
            }
            private string model;
            public string Model
            {
                get { return model; }
                set { model = value; }
            }
            private int year;
            public int Year
            {
                get { return year; }
                set { year = value; }
            }

            public Car(string make, string model, int year)
            {
                this.make = make;
                this.model = model;
                this.year = year;
            }

            public void GetCarInfo()
            {
                Console.WriteLine($"Make: {make}; Model: {model}; Year: {year}");
            }
        }

        static void Main(string[] args)
        {
            Car car = new Car("Honda", "Civic", 2000);
            car.GetCarInfo();
            car.Make = "Skoda";
            car.Model = "Octavia";
            car.Year = 2005;
            car.GetCarInfo();
        }
    }
}
