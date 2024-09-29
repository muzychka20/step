using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public static class Menu
    {
        public static void ShowMainMenu()
        {
            Console.WriteLine("1. Add car");
            Console.WriteLine("2. Add bicycle");
            Console.WriteLine("3. Add truck");
            Console.WriteLine("4. Show all");
            Console.WriteLine("5. Calculate fuel consumption for distance");
            Console.WriteLine("6. Exit");
        }

        public static void AddCar()
        {
            string brand, model;
            int maxSpeed;
            double fuelConsumption;

            Console.WriteLine("Enter brand: "); brand = Console.ReadLine();
            Console.WriteLine("Enter model: "); model = Console.ReadLine();
            Console.WriteLine("Max speed: "); maxSpeed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fuel consumption: "); fuelConsumption = Convert.ToDouble(Console.ReadLine());

            Car car = new Car(brand, model, maxSpeed, fuelConsumption);
            Store.vehicles.Add(car);
            Console.WriteLine("Car added!");
        }

        public static void AddBicycle()
        {
            string brand, model;
            int maxSpeed;

            Console.WriteLine("Enter brand: "); brand = Console.ReadLine();
            Console.WriteLine("Enter model: "); model = Console.ReadLine();
            Console.WriteLine("Max speed: "); maxSpeed = Convert.ToInt32(Console.ReadLine());

            Bicycle bicycle = new Bicycle(brand, model, maxSpeed);
            Store.vehicles.Add(bicycle);
            Console.WriteLine("Bicycle added!");
        }

        public static void AddTruck()
        {
            string brand, model;
            int maxSpeed;
            double fuelConsumption, loadCapacity;

            Console.WriteLine("Enter brand: "); brand = Console.ReadLine();
            Console.WriteLine("Enter model: "); model = Console.ReadLine();
            Console.WriteLine("Max speed: "); maxSpeed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fuel consumption: "); fuelConsumption = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Load Capacity: "); loadCapacity = Convert.ToDouble(Console.ReadLine());

            Truck truck = new Truck(brand, model, maxSpeed, fuelConsumption, loadCapacity);
            Store.vehicles.Add(truck);
            Console.WriteLine("Truck added!");
        }

        public static void ShowAll()
        {
            foreach (var vehicle in Store.vehicles)
            {
                vehicle.DisplayInfo();
            }
        }

        public static void CalcFuelConsumption()
        {
            Console.WriteLine("Enter distance: "); double dist = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter vehicle id: "); int id = Convert.ToInt32(Console.ReadLine());
            VehicleBase vehicle = Store.GetVehicleById(id);
            Console.WriteLine($"Fuel consumption of {vehicle.Brand} {vehicle.Model} for {dist}: " + vehicle.CalculateFuelConsumption(dist));
        }

        public static bool Exit()
        {
            return false;
        }
    }
}
