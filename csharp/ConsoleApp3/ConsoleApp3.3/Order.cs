using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3._3
{
    public class Order
    {
        public List<int> produtsPrice;

        public Order(List<int> arr)
        {
            produtsPrice = arr;
        }

        public virtual int CalculateTotal()
        {
            return produtsPrice.Sum();
        }
    }
}
