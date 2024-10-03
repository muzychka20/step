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
        public static int id = 0;
        public int Id { get; }
        List<Tuple<Product, int>> products;
        public double Total { get; set; }
        public DateTime Date { get; set; }
        public StatusName Status { get; set; }
        public IDiscount Discount { get; set; }

        public Order(List<Tuple<Product, int>> _products)
        {
            Id = id++;
            products = _products;
            Date = DateTime.Now;
            Status = StatusName.New;
            Total = CalculateTotal();
        }
        
        public double CalculateTotal()
        {
            double total = 0;
            foreach (var product in products)
            {
                total += product.Item1.Price * product.Item2;
            }            
            return total;
        }

        public void AddProduct(Product product, int amount)
        {
            products.Add(new Tuple<Product, int>(product, amount));
        }

        public void RemoveProduct(int productId)
        {
            var productToRemove = products.Find(product => product.Item1.Id == productId);
            products.Remove(productToRemove);
        }

        public void ChangeProductQuantity(int productId, int newAmount)
        {
            var index = products.FindIndex(t => t.Item1.Id == productId);
            var productToEdit = products.Find(product => product.Item1.Id == productId);
            var newProduct = new Tuple<Product, int>(productToEdit.Item1, newAmount);
            products[index] = newProduct;
        }

        public void ApplyDiscount()
        {
            Tuple<Product, int> CompareAmountTo(int amount)
            {
                foreach (var product in products)
                {
                    if (product.Item2 > amount)
                    {
                        return product;
                    }
                }
                return null;
            }

            double total = CalculateTotal();

            if (total > 5000)
            {
                Discount = new OrderDiscount();
                Total -= Discount.CalculateDiscount(total);
            }
            
            var prod = CompareAmountTo(5);
            if (prod != null && Discount != null)
            {
                Discount = new ProductDiscount();
                Total -= prod.Item2 * Discount.CalculateDiscount(prod.Item1.Price);
            }
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
            res += "---------------------\n";
            return res;
        }
    }
}
