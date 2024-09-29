using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public interface IVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public void DisplayInfo();
    }
}
