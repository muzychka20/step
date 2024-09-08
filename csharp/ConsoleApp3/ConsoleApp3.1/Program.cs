using System;

namespace ConsoleApp3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("make1", "vehicle", 2000);
            vehicle.StartEngine();
            vehicle.DisplayInfo();
            Console.WriteLine("-----------------------------------");

            Car car = new Car("make2", "car", 2010, 45.1);
            car.StartEngine();
            car.DisplayInfo();
            Console.WriteLine("-----------------------------------");


            Motorcycle motorcycle = new Motorcycle("make3", "motorcycle", 2024, true);
            motorcycle.StartEngine();
            motorcycle.DisplayInfo();
            Console.WriteLine("-----------------------------------");
        }
    }
}
