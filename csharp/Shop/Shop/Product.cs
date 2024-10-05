using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Product
    {
        public static int id = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }

        public Product(string name, double price, int amount)
        {
            Id = id++;
            Name = name;
            Price = price;
            Amount = amount;
        }

        public void ChangePrice(double newPrice)
        {
            Price = newPrice;
        }

        public void ChangeStock(int newAmount)
        {
            Amount = newAmount;
        }

        public override string ToString()
        {
            return $"Id: {Id}\n" +
                    $"Name: {Name}\n" +
                    $"Price: {Price}\n" +
                    $"Amount: {Amount}";
        }
    }
}
