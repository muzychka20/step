using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Customer : User
    {
        public List<Order> ordersHistory;

        public Customer(string name)
        {
            Name = name;
            Id = id++;
        }

        public void ViewOrderHistory()
        {
            foreach(var order in ordersHistory)
            {
                Console.WriteLine(order.ToString());
            }
        }

        public void GetDiscounts()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Customer ID: {Id}, Name: {Name}";
        }
    }
}
