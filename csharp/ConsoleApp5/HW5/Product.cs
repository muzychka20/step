using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW5.Exceptions;

namespace HW5
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public Product(int id, string name, double price, int stock)
        {
            Id = id;
            Name = name;
            Price = price;
            Stock = stock;
        }

        public void Purchase(int quantity)
        {
            if (quantity > Stock)
            {
                throw new InsufficientStockException("Insufficient quantity in stock!");
            }
            Stock -= quantity;
        }
    }
}
