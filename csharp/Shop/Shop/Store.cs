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
        public static List<Order> orders = new List<Order>();
        public static List<Customer> customers = new List<Customer>();

        public static void ShowProducts()
        {
            foreach (var item in products)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void ShowOrders()
        {
            foreach (var item in orders)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void ShowCustomers()
        {
            foreach (var item in customers)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void ShowOrderHistoryByCustomerId(int customerId)
        {
            var customerOrders = orders.Where(o => o.CustomerId == customerId).ToList();

            if (customerOrders.Any())
            {
                Console.WriteLine($"Order History for Customer ID: {customerId}");
                foreach (var order in customerOrders)
                {
                    Console.WriteLine(order.ToString());
                }
            }
            else
            {
                Console.WriteLine("No orders found for this customer.");
            }
        }
    }
}
