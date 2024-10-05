using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Reports
{
    public interface IReportFactory
    {
        IReport CreateSalesReport(DateTime startDate, DateTime endDate);
        IReport CreatePopularProductsReport();
        IReport CreateCustomerReport(int customerId);
    }
}
