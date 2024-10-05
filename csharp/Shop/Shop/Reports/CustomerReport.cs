using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Reports
{
    public class CustomerReport : IReport
    {
        private List<Order> orders;
        private int customerId;

        public CustomerReport(List<Order> orders, int customerId)
        {
            this.orders = orders;
            this.customerId = customerId;
        }

        public void GenerateReport()
        {
            var customerOrders = orders
                .Where(o => o.CustomerId == customerId)
                .ToList();

            if (customerOrders.Any())
            {
                Console.WriteLine($"Customer Report for ID {customerId}:");

                foreach (var order in customerOrders)
                {
                    Console.WriteLine(order.ToString());
                }
            }
            else
            {
                Console.WriteLine($"No orders found for customer ID {customerId}.");
            }
        }
    }
}