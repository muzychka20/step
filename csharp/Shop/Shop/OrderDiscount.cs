using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class OrderDiscount : IDiscount
    {
        public double CalculateDiscount(double price)
        {
            return price * 0.05;
        }
    }
}
