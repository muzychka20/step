using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public static class Store
    {
        public static List<VehicleBase> vehicles = new List<VehicleBase>();
        public static VehicleBase GetVehicleById(int _id)
        {
            return vehicles.Find(v => v.ID == _id);           
        }
    }
}
