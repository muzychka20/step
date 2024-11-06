using System;
using System.Threading;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<int> listTasks = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                int n = rand.Next();
                listTasks.Add(n);
            }

            foreach (var item in listTasks)
            {
                ThreadPool.QueueUserWorkItem(CompleteTask, item);
            }

            Thread.Sleep(5000);
            Console.WriteLine("Основной поток завершает выполнение.");
        }

        static void CompleteTask(object state)
        {
            string dataItem = state as string;
            Console.WriteLine($"Обработка {dataItem} начата в потоке {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(2000);
        }
    }
}
