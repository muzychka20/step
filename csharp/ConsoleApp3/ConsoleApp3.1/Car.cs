using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3._1
{
    public class Car : Vehicle
    {
        public double TrunkSize { get; set; }

        public Car(string make, string model, int year, double trunkSize) :
            base(make, model, year) 
        {
            TrunkSize = trunkSize;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Trunk Size: {TrunkSize}");            
        }
    }
}
