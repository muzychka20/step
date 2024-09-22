/*
Задание 3:

Задание: Реализация интерфейса ICloneable для класса автомобиля

Описание:
Необходимо реализовать класс Car, который будет представлять автомобиль. Класс должен иметь следующие свойства:

Model — модель автомобиля (строка)
Manufacturer — производитель автомобиля (строка)
Year — год выпуска (целое число)
Price — цена автомобиля (десятичное число)
Реализуйте интерфейс ICloneable, чтобы можно было создать копию объекта класса Car.

Требования:
Реализуйте класс Car с необходимыми свойствами.
Реализуйте метод Clone из интерфейса ICloneable для глубокого копирования объекта.
Проверьте работу метода Clone на практике:
Создайте объект автомобиля.
Склонируйте его с помощью метода Clone.
Измените свойства клонированного объекта и убедитесь, что это не влияет на оригинальный объект.
*/

public class Car : ICloneable
{
    public string Model { get; set; }
    public string Manufacturer { get; set; }
    public int Year { get; set; }
    public double Price { get; set; }

    public Car(string model, string manufacturer, int year, double price)
    {
        Model = model;
        Manufacturer = manufacturer;
        Year = year;
        Price = price;
    }

    public override string ToString()
    {
        return $"Model: {Model}\nManufacturer: {Manufacturer}\nYear: {Year}\nPrice: {Price}";        
    }

    public object Clone()
    {
        return this.MemberwiseClone();        
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("Octavia", "Skoda", 2024, 20000);
        Car clone = (Car)car.Clone();

        clone.Model = "Civic";
        clone.Manufacturer = "Honda";
        clone.Year = 2020;
        clone.Price = 15000;

        Console.WriteLine("Original Car:");
        Console.WriteLine(car.ToString());
        Console.WriteLine("------------");
        Console.WriteLine("Cloned Car:");
        Console.WriteLine(clone.ToString());
    }
}
