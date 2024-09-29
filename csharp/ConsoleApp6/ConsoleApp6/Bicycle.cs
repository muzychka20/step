using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Bicycle : VehicleBase
    {        
        public override int ID { get; }
        public override int MaxSpeed { get; }
        public override double FuelConsumption { get; set; }


        public Bicycle(string brand, string model, int maxSpeed)
        {
            ID = id++;
            Brand = brand;
            Model = model;
            MaxSpeed = maxSpeed;
            FuelConsumption = 0;
        }

        public override double CalculateFuelConsumption(double distance)
        {
            return FuelConsumption;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"{ID}. Brand: {Brand}; Model: {Model}; MaxSpeed: {MaxSpeed}; FuelConsumption: {FuelConsumption}");
        }
    }
}
