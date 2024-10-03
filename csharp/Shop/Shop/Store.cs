using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Store
    {
        public static List<Product> products = new List<Product>();

        public static void ShowProducts()
        {
            foreach (var item in products)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
