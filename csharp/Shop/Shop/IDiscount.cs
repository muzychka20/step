using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public interface IDiscount
    {
        // public string TypeName { get; set; } /// TODO
        public double CalculateDiscount(double price);
    }
}
