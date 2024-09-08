using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3._3
{
    class OnlineOrder : Order
    {
        public int sale;

        public OnlineOrder(List<int> arr, int sale) : base(arr) 
        {
            this.sale = sale;
        }

        public override int CalculateTotal()
        {
            return produtsPrice.Sum() - produtsPrice.Sum() * sale / 100;
        }
    }
}
