using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Truck : VehicleBase
    {
        public override int ID { get; }
        public override int MaxSpeed { get; }
        public override double FuelConsumption { get; set; }
        public double LoadCapacity { get; set; }


        public Truck(string brand, string model, int maxSpeed, double fuelConsumption, double loadCapacity)
        {
            ID = id++;
            Brand = brand;
            Model = model;
            MaxSpeed = maxSpeed;
            FuelConsumption = fuelConsumption;
            LoadCapacity = loadCapacity;
        }

        public override double CalculateFuelConsumption(double distance)
        {
            return (distance / 100) * FuelConsumption + FuelConsumption * 0.1 * LoadCapacity;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"{ID}. Brand: {Brand}; Model: {Model}; MaxSpeed: {MaxSpeed}; FuelConsumption: {FuelConsumption} l/100km");
        }
    }
}
