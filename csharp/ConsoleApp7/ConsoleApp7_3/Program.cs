/*
Создайте консольное приложение, которое будет
моделировать процесс обработки данных с использованием делегатов.

Приложение должно выполнять следующие шаги:
Создайте делегат DataProcessor, который принимает строку и возвращает строку.
Создайте несколько методов, которые соответствуют 
делегату DataProcessorи выполняют следующие действия:
- ToUpper: переводит строку в верхний регистр.
- AddExclamation: добавляет в конец строки восклицательный знак.
- ReplaceSpacesWithDashes: заменяет все пробелы в строке на дефисы.
- Reverse: разворачивает строку (например, "abc" становится "cba").

Создайте метод, который будет принимать строку и массив делегатов DataProcessor,
а затем последовательно применять каждый из них к строке.

Создайте метод, который принимает массив строк и один делегат DataProcessor.
Метод должен применять этот делегат к каждому элементу массива строк.

Реализуйте логику, которая позволит пользователю выбрать операции для обработки строки,
вводя соответствующие команды в консоль.
*/

using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace ConsoleApp7
{
    public delegate string DataProcessor(string str);

    class Program
    {
        static void PerformOperation(List<DataProcessor> dt, string str)
        {
            foreach (var item in dt)
            {
                str = item(str);
            }
            Console.WriteLine($"Result: {str}");
        }

        static void PerformOperationForArray(DataProcessor dt, List<string> str)
        {
            for(int i = 0; i < str.Count; i++)
            {
                str[i] = dt(str[i]);
            }
            Console.WriteLine("Result:");
            foreach (var item in str)
            {
                Console.WriteLine($"{item}");
            }
        }

        static void Main(string[] args)
        {
            // 1
            List<DataProcessor> dataProcessors = new List<DataProcessor>()
            {
                ToUpper,
                ReplaceSpacesWithDashes,
                Reverse,
                AddExclamation,
            };
            PerformOperation(dataProcessors, "abcd xyz");

            // 2
            DataProcessor dataProcessorForArr = ToUpper;
            PerformOperationForArray(dataProcessorForArr, new List<string>() { "abc", "name", "letter last" });

            // 3            
            Console.WriteLine("Enter the string:");
            string input = Console.ReadLine();

            while (true)
            {                
                Console.WriteLine("1 - ToUpper");
                Console.WriteLine("2 - AddExclamation");
                Console.WriteLine("3 - ReplaceSpacesWithDashes");
                Console.WriteLine("4 - Reverse");
                Console.WriteLine("0 - Exit");             

                string choice = Console.ReadLine();

                if (choice == "0")
                {
                    break;
                }

                DataProcessor selectedProcessor = null;

                switch (choice)
                {
                    case "1":
                        selectedProcessor = ToUpper;
                        break;
                    case "2":
                        selectedProcessor = AddExclamation;
                        break;
                    case "3":
                        selectedProcessor = ReplaceSpacesWithDashes;
                        break;
                    case "4":
                        selectedProcessor = Reverse;
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        continue;
                }

                // Применяем выбранный делегат
                input = selectedProcessor(input);
                Console.WriteLine($"After operations: {input}");
            }
        }

        static string ToUpper(string str)
        {
            return str.ToUpper();
        }

        static string AddExclamation(string str)
        {
            return str + "!";
        }

        static string ReplaceSpacesWithDashes(string str)
        {
            return str.Replace(" ", "-");
        }

        static string Reverse(string str)
        {
            return new string(str.Reverse().ToArray());
        }
    }
}