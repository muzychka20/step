using Shop.Reports;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuPresenter presenter = new MenuPresenter();
            App app = new App(presenter);
        }
    }

    public class App
    {
        MenuPresenter AppInterface;

        public App(MenuPresenter menuPresenter)
        {
            AppInterface = menuPresenter;
            MainMenu();
        }

        public void MainMenu()
        {            
            while (true)
            {
                try
                {
                    AppInterface.ShowMainMenu();
                    int choose = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (choose)
                    {
                        case 1:
                            ProductMenu();
                            break;
                        case 2:
                            OrderMenu();
                            break;
                        case 3:
                            CustomerMenu();
                            break;
                        case 4:
                            ReportsMenu();
                            break;                                              
                        default:
                            Console.WriteLine("Invalid choice!");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                }
            }
        }

        public void ProductMenu()
        {
            while (true)
            {
                AppInterface.ShowProductMenu();
                int choose = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (choose)
                {
                    case 1:
                        {
                            Console.WriteLine("Name: "); string name = Console.ReadLine();
                            Console.WriteLine("Price: "); double price = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Amount: "); int amount = Convert.ToInt32(Console.ReadLine());
                            Store.products.Add(new Product(name, price, amount));
                            Console.WriteLine("Added!"); Console.ReadKey();
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Id: "); int id = Convert.ToInt32(Console.ReadLine());
                            int removedCount = Store.products.RemoveAll(p => p.Id == id);
                            if (removedCount > 0)
                            {
                                Console.WriteLine("Deleted!");
                            }
                            else
                            {
                                Console.WriteLine("Product not found.");
                            }
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Id: "); int id = Convert.ToInt32(Console.ReadLine());
                            Product productToEdit = Store.products.FirstOrDefault(p => p.Id == id);
                            if (productToEdit != null)
                            {
                                Console.WriteLine("Name: "); string name = Console.ReadLine();
                                Console.WriteLine("Price: "); double price = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Amount: "); int amount = Convert.ToInt32(Console.ReadLine());
                                productToEdit.Name = name;
                                productToEdit.Price = price;
                                productToEdit.Amount = amount;
                                Console.WriteLine("Edited!"); Console.ReadKey();
                                Console.ReadKey();
                            }
                            break;
                        }
                    case 4:
                        {
                            Store.ShowProducts();
                            Console.ReadKey();
                            break;
                        }
                    case 5:
                        {                            
                            MainMenu();
                            break;
                        }
                }
            }
        }

        public void OrderMenu()
        {            
            while (true)
            {
                AppInterface.ShowOrderMenu();
                int choose = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (choose)
                {
                    case 1:
                        {
                            if (Store.customers.Count() > 0)
                            {
                                List<Tuple<Product, int>> orderProducts = new List<Tuple<Product, int>>();
                                Store.ShowProducts();
                                while (true)
                                {
                                    Console.WriteLine("Add product to order by ID (or enter 0 to finish): ");
                                    int productId = Convert.ToInt32(Console.ReadLine());

                                    if (productId == 0)
                                        break;

                                    Product product = Store.products.FirstOrDefault(p => p.Id == productId);
                                    if (product == null)
                                    {
                                        Console.WriteLine("Product not found.");
                                        continue;
                                    }

                                    bool inList = false;
                                    foreach (var pr in orderProducts)
                                    {
                                        if (product.Id == pr.Item1.Id)
                                        {
                                            Console.WriteLine("Product already in list!");
                                            inList = true;
                                            break;
                                        }
                                    }
                                    if (inList)
                                    {
                                        continue;
                                    }

                                    Console.WriteLine("Enter amount: ");
                                    int amount = Convert.ToInt32(Console.ReadLine());

                                    orderProducts.Add(new Tuple<Product, int>(product, amount));
                                }
                                if (orderProducts.Count > 0)
                                {
                                    Customer customer = null; int id;
                                    do
                                    {
                                        Console.WriteLine("Attach to customer (enter id): "); id = Convert.ToInt32(Console.ReadLine());
                                        customer = Store.customers.FirstOrDefault(c => c.Id == id);
                                    } while (customer == null);


                                    Order newOrder = new Order(id, orderProducts);
                                    Store.orders.Add(newOrder);
                                    Console.WriteLine("Order created successfully!");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("No products added to the order.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Add customers first!");
                            }
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter Order ID to change status: ");
                            Store.ShowOrders();
                            int orderId = Convert.ToInt32(Console.ReadLine());
                            Order orderToEdit = Store.orders.FirstOrDefault(o => o.Id == orderId);

                            if (orderToEdit != null)
                            {
                                Console.WriteLine("1. New");
                                Console.WriteLine("2. In Processing");
                                Console.WriteLine("3. Delivered");
                                int statusChoice = Convert.ToInt32(Console.ReadLine());

                                switch (statusChoice)
                                {
                                    case 1:
                                        orderToEdit.ChangeOrderStatus(StatusName.New);
                                        break;
                                    case 2:
                                        orderToEdit.ChangeOrderStatus(StatusName.InProgress);
                                        break;
                                    case 3:
                                        orderToEdit.ChangeOrderStatus(StatusName.Delivered);
                                        break;
                                }

                                Console.WriteLine("Order status updated!");
                            }
                            else
                            {
                                Console.WriteLine("Order not found.");
                            }
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            Store.ShowOrders();
                            Console.ReadKey();
                            break;
                        }
                    case 4:
                        {                            
                            MainMenu();
                            break;
                        }
                }
            }
        }

        public void CustomerMenu()
        {            
            while (true)
            {
                AppInterface.ShowCustomerMenu();
                int choose = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (choose)
                {
                    case 1:
                        {
                            Console.WriteLine("Name: "); string name = Console.ReadLine();
                            Store.customers.Add(new Customer(name));
                            Console.WriteLine("Added!");
                            break;
                        }
                    case 2:
                        {
                            Store.ShowCustomers();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter customer ID: ");
                            int _customerId = Convert.ToInt32(Console.ReadLine());
                            Store.ShowOrderHistoryByCustomerId(_customerId);
                            break;
                        }
                    case 4:
                        {                            
                            MainMenu();
                            break;
                        }
                }
                Console.ReadKey();
            }
        }

        public void ReportsMenu()
        {
            IReportFactory reportFactory = new ReportFactory(Store.orders);            
            while (true)
            {
                AppInterface.ShowReportsMenu();
                int choose = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (choose)
                {
                    case 1:
                        GenerateSalesReport(reportFactory);
                        break;
                    case 2:
                        GeneratePopularProductsReport(reportFactory);
                        break;
                    case 3:
                        GenerateCustomerReport(reportFactory);
                        break;
                    case 4:                        
                        MainMenu();
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
                Console.ReadKey();
            }
        }

        private void GenerateSalesReport(IReportFactory reportFactory)
        {
            Console.WriteLine("Enter the start date (yyyy-mm-dd): ");
            DateTime startDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter the end date (yyyy-mm-dd): ");
            DateTime endDate = DateTime.Parse(Console.ReadLine());

            IReport salesReport = reportFactory.CreateSalesReport(startDate, endDate);
            salesReport.GenerateReport();
        }

        private void GeneratePopularProductsReport(IReportFactory reportFactory)
        {
            IReport popularProductsReport = reportFactory.CreatePopularProductsReport();
            popularProductsReport.GenerateReport();
        }

        private void GenerateCustomerReport(IReportFactory reportFactory)
        {
            Console.WriteLine("Enter customer ID: ");
            int customerId = Convert.ToInt32(Console.ReadLine());

            IReport customerReport = reportFactory.CreateCustomerReport(customerId);
            customerReport.GenerateReport();
        }
    }
}
