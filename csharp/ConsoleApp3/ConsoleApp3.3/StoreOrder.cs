using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3._3
{
    public class StoreOrder : Order
    {
        public int tax;

        public StoreOrder(List<int> arr, int tax) : base(arr)
        {
            this.tax = tax;
        }

        public override int CalculateTotal()
        {
            return produtsPrice.Sum() + produtsPrice.Sum() * tax / 100;
        }
    }
}
