using HW5.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }

        public Customer(int id, string name, double balance)
        {
            Id = id;
            Name = name;
            Balance = balance;
        }

        public void PlaceOrder(Product product, int quantity)
        {
            double total = product.Price * quantity;
            if (total > Balance)
            {
                throw new InsufficientFundsException("Not enough funds");
            }
            Balance -= total;
        }
    }
}
