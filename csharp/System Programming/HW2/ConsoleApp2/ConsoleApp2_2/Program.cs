using System;
using System.Threading;

namespace ConsoleApp2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] urls = { "url1", "url2", "url3", "url4", "url5" };

            foreach (var url in urls)
            {
                ThreadPool.QueueUserWorkItem(DownloadTask, url);
            }

            Thread.Sleep(10000);
            Console.WriteLine("Основной поток завершает выполнение.");
        }

        static void DownloadTask(object state)
        {
            string url = state as string;
            DateTime dt0 = DateTime.Now;
            Thread.Sleep(new Random().Next(2000, 5000));
            DateTime dt1 = DateTime.Now;
            Console.WriteLine($"Скачивание {url}, начало: {dt0}, конец: {dt1}, поток: {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
