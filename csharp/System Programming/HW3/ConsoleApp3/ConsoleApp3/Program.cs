using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static async Task Main(string[] args)
        {
            int max = 0;
            List<int> list = new List<int>();
            List<int> maxVal = new List<int>();
            Random rand = new Random();

            for (int i = 0; i < 900_000; i++)
            {
                int number = rand.Next();
                list.Add(number);
            }        
           
            Console.WriteLine("Выполняем задачу...");
            
            maxVal.Add(await CalculateMax(0, 300_000, list));
            maxVal.Add(await CalculateMax(300_000, 600_000, list));
            maxVal.Add(await CalculateMax(600_000, 900_000, list));
                        
            Console.WriteLine("Maxes: ");
            foreach (var el in maxVal)
                Console.WriteLine(el);

            Console.WriteLine("Max: ");
            for (int i = 1; i < maxVal.Count; i++)
            {
                max = Math.Max(maxVal[i - 1], maxVal[i]);
            }
            Console.WriteLine(max);            
        }


        static async Task<int> CalculateMax(int start, int end, List<int> list)
        {
            int max = Int32.MinValue;            
            Parallel.For(start, end, i =>
            {
                if (max < list[i])
                {
                    max = list[i];
                }
            });
            return max;
        }
    }
}
