using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Car : VehicleBase
    { 
        public override int ID { get; }
        public override int MaxSpeed { get; }
        public override double FuelConsumption { get; set; }


        public Car(string brand, string model, int maxSpeed, double fuelConsumption)
        {
            ID = id++;
            Brand = brand;
            Model = model;
            MaxSpeed = maxSpeed;
            FuelConsumption = fuelConsumption;
        }

        public override double CalculateFuelConsumption(double distance)
        {
            return (distance / 100) * FuelConsumption;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"{ID}. Brand: {Brand}; Model: {Model}; MaxSpeed: {MaxSpeed}; FuelConsumption: {FuelConsumption} l/100km");
        }
    }
}
