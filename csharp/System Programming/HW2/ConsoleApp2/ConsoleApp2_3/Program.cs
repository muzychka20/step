using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApp2_3
{
    class Program
    {
        static async Task Main(string[] args)
        {
            List<string> filesPath = new List<string>();
            for (int i = 1; i <= 20; i++)
            {
                filesPath.Add($"C:\\lessons\\csharp\\sys prog\\Lesson 2\\3.11\\Пример {i}.txt");                
            }
            foreach (var path in filesPath)
            {
                await ReadCharacters(path);
            }
        }

        static async Task ReadCharacters(object state)
        {
            string path = state as string;
            using (StreamReader reader = File.OpenText(path))
            {
                Console.WriteLine("Opened file: " + path);
                string result = await reader.ReadToEndAsync();
                Console.WriteLine($"Size: {result.Length}\nContains:");
                for (int i = 0; i < 100; i++)
                {
                    Console.Write(result[i]);
                }
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------");
            }
        }
    }
}