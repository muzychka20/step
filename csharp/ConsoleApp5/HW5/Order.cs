using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    public class Order
    {
        public int OrderId { get; set; }
        public Customer customer { get; set; }
        public Product product { get; set; }
        public int Quantity { get; set; }

        public Order(int orderId, Customer _customer, Product _product, int quantity)
        {
            OrderId = orderId;
            customer = _customer;
            product = _product;
            Quantity = quantity;
        }

        public void ProcessOrder()
        {
            try
            {
                product.Purchase(Quantity);
                customer.PlaceOrder(product, Quantity);
                Console.WriteLine("Order successfully processed!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
