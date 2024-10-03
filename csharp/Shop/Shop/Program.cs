using System;
using System.Linq;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            App.MainMenu();
        }
    }

    public class App
    {
        private static void ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Manage products");
        }

        private static void ShowProductMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Add product");
            Console.WriteLine("2. Delete product");
            Console.WriteLine("3. Edit product");
            Console.WriteLine("4. Show products");
            Console.WriteLine("5. Back");
        }

        public static void MainMenu()
        {

            while (true)
            {
                try
                {
                    ShowMainMenu();
                    int choose = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (choose)
                    {
                        case 1:
                            ProductMenu();
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

        public static void ProductMenu()
        {
            while (true)
            {
                ShowProductMenu();
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
                            Store.products.RemoveAll(p => p.Id == id);
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
    }
}
