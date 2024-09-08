using System;
using System.Collections.Generic;

namespace ConsoleApp3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 1, 2, 3, 4 };
            
            Order order = new Order(arr);
            Console.WriteLine($"Total ( order ) = {order.CalculateTotal()}");

            Order onlineOrder = new OnlineOrder(arr, 20);
            Console.WriteLine($"Total ( online order ) = {((OnlineOrder)onlineOrder).CalculateTotal()}");

            Order storeOrder = new StoreOrder(arr, 20);
            Console.WriteLine($"Total ( stored order ) = {((StoreOrder)storeOrder).CalculateTotal()}");
        }
    }
}
