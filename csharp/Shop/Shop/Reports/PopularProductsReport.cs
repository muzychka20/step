using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Reports
{
    public class PopularProductsReport : IReport
    {
        private List<Order> orders;

        public PopularProductsReport(List<Order> orders)
        {
            this.orders = orders;
        }

        public void GenerateReport()
        {
            var productPopularity = orders
                .SelectMany(o => o.products)
                .GroupBy(p => p.Item1)
                .Select(g => new { Product = g.Key, Quantity = g.Sum(p => p.Item2) })
                .OrderByDescending(p => p.Quantity)
                .ToList();

            Console.WriteLine("Popular Products Report:");
            foreach (var product in productPopularity)
            {
                Console.WriteLine($"{product.Product.Name}: {product.Quantity} sold");
            }
        }
    }
}
