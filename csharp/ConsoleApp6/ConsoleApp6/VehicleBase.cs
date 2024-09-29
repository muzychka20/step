using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public abstract class VehicleBase : IVehicle
    {
        protected static int id = 0; 
        public abstract int ID { get; }
        public string Brand { get; set; }
        public string Model { get; set; }

        public abstract int MaxSpeed { get; }
        public abstract double FuelConsumption { get; set; }

        public abstract double CalculateFuelConsumption(double distance);

        public abstract void DisplayInfo();        
    }
}
