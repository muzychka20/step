using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {                
                Menu.ShowMainMenu();
                int choose = Convert.ToInt32(Console.ReadLine());
                switch(choose)
                {
                    case 1:
                        Menu.AddCar();
                        break;
                    case 2:
                        Menu.AddBicycle();
                        break;
                    case 3:
                        Menu.AddTruck();
                        break;
                    case 4:
                        Menu.ShowAll();
                        break;
                    case 5:
                        Menu.CalcFuelConsumption();
                        break;
                    case 6:
                        isRunning = Menu.Exit();
                        break;
                }
                Console.WriteLine();
            }            
        }
    }    
}
