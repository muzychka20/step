using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop;

namespace Shop.Reports
{
    public class SalesReport : IReport
    {
        private List<Order> orders;
        private DateTime startDate;
        private DateTime endDate;

        public SalesReport(List<Order> orders, DateTime startDate, DateTime endDate)
        {
            this.orders = orders;
            this.startDate = startDate;
            this.endDate = endDate;
        }

        public void GenerateReport()
        {
            var salesInPeriod = orders
                .Where(o => o.Date >= startDate && o.Date <= endDate)
                .SelectMany(o => o.products)
                .ToList();

            double totalSales = salesInPeriod.Sum(p => p.Item1.Price * p.Item2);
            int totalItemsSold = salesInPeriod.Sum(p => p.Item2);

            Console.WriteLine($"Sales report from {startDate.ToShortDateString()} to {endDate.ToShortDateString()}:");
            Console.WriteLine($"Total items sold: {totalItemsSold}");
            Console.WriteLine($"Total sales amount: {totalSales}");
        }
    }
}
