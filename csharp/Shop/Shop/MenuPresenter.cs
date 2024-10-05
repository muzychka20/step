using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class MenuPresenter
    {
        public void ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Manage products");
            Console.WriteLine("2. Manage orders");
            Console.WriteLine("3. Manage customers");
            Console.WriteLine("4. View reports");            
        }

        public void ShowProductMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Add product");
            Console.WriteLine("2. Delete product");
            Console.WriteLine("3. Edit product");
            Console.WriteLine("4. Show products");
            Console.WriteLine("5. Back");
        }

        public void ShowOrderMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Create new order");
            Console.WriteLine("2. Change order status");
            Console.WriteLine("3. Show all orders");
            Console.WriteLine("4. Back");
        }

        public void ShowCustomerMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Add customer");
            Console.WriteLine("2. Show customers");
            Console.WriteLine("3. Show order history by customer id");            
            Console.WriteLine("4. Back");
        }

        public void ShowReportsMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Sales Report");
            Console.WriteLine("2. Popular Products Report");
            Console.WriteLine("3. Customer Orders Report");
            Console.WriteLine("4. Back");
        }
    }
}
