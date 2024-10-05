using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Order
    {
        public static int id = 1;
        public int Id { get; }
        public List<Tuple<Product, int>> products;
        public double Total { get; set; }
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
        public StatusName Status { get; set; }
        public IDiscount Discount { get; set; }

        public Order(int customerId, List<Tuple<Product, int>> _products)
        {
            Id = id++;
            products = new List<Tuple<Product, int>>();
            foreach (var product in _products)
            {
                AddProduct(product.Item1, product.Item2);
            }
            CustomerId = customerId;
            Date = DateTime.Now;
            Status = StatusName.New;
            CalculateTotal();
        }

        public void CalculateTotal()
        {
            double total = 0;
            foreach (var product in products)
            {
                total += product.Item1.Price * product.Item2;
            }

            Total = total;

            List<Tuple<Product, double>> discountsApplied = new List<Tuple<Product, double>>();
            
            if (Total > 5000)
            {               
                ApplyDiscount(new OrderDiscount(), Total);
                Console.WriteLine($"Applied discount on order!");
                return;
            }

            foreach (var product in products)
            {
                if (product.Item2 > 5)
                {
                    double productDiscountAmount = product.Item1.Price * product.Item2;
                    ApplyDiscount(new ProductDiscount(), productDiscountAmount);
                }
            }
        }

        public void AddProduct(Product product, int amount)
        {
            if (product.Amount >= amount)
            {
                products.Add(new Tuple<Product, int>(product, amount));
                product.ChangeStock(product.Amount - amount);
            }
            else
            {
                throw new Exception($"Not enough produts with id {product.Id}!");
            }
        }

        public void RemoveProduct(int productId)
        {
            products.RemoveAll(p => p.Item1.Id == productId);
        }

        public void ChangeProductQuantity(int productId, int newAmount)
        {
            var index = products.FindIndex(t => t.Item1.Id == productId);
            var productToEdit = products.Find(product => product.Item1.Id == productId);
            var newProduct = new Tuple<Product, int>(productToEdit.Item1, newAmount);
            products[index] = newProduct;
        }

        public void ApplyDiscount(IDiscount discount, double priceBeforeDiscount)
        {
            Discount = discount;
            Total -= Discount.CalculateDiscount(priceBeforeDiscount);
        }

        public void ChangeOrderStatus(StatusName stName)
        {
            Status = stName;
        }

        public override string ToString()
        {
            string res = "";
            res += "---------------------\n";
            res += $"Order Number: {Id}\n";
            foreach (var product in products)
            {
                res += $"{product.Item1.Name} ({product.Item1.Price}): {product.Item2}\n";
            }
            res += "Date: " + Date.ToString() + "\n";
            res += $"Status: {Status}\n";
            res += $"Total: {Total}\n";
            res += "---------------------\n";
            return res;
        }
    }
}
