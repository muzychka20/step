using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Reports
{
    public class ReportFactory : IReportFactory
    {
        private List<Order> orders;

        public ReportFactory(List<Order> orders)
        {
            this.orders = orders;
        }

        public IReport CreateSalesReport(DateTime startDate, DateTime endDate)
        {
            return new SalesReport(orders, startDate, endDate);
        }

        public IReport CreatePopularProductsReport()
        {
            return new PopularProductsReport(orders);
        }

        public IReport CreateCustomerReport(int customerId)
        {
            return new CustomerReport(orders, customerId);
        }
    }

}
