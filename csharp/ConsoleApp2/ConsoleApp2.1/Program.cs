/*Задание 2
Перевод числа в текст
Описание: Напишите функцию NumberToWords, которая принимает целое число и возвращает его текстовое представление на английском языке. Ограничьтесь числами в диапазоне от 0 до 9999.
Требования:
Обработайте числа от 0 до 9999.
Используйте отдельные функции для обработки сотен, десятков и единиц.
*/
using System;

namespace ConsoleApp2._1
{
    class Program
    {
        static string[] names = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        static void Main(string[] args)
        {
            Console.Write("n = ");
            string n = Console.ReadLine();
            string res = "";    
            foreach (char digit in n) {
                res += names[(int)digit-48] + " ";
            }
            Console.WriteLine("Res:" + res);
        }
    }
}
