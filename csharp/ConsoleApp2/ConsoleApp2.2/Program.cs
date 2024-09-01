/*
Задание 3
Описание: Напишите функцию SumOfDigits, которая принимает целое число и возвращает сумму его цифр.
Требования:
Реализуйте функцию, которая разбивает число на отдельные цифры и суммирует их.
Обеспечьте корректную работу функции с отрицательными числами.
*/
using System;

namespace ConsoleApp2._2
{
    class Program
    {
        static int SumOfDigits(int n)
        {            
            n = Math.Abs(n);
            return n == 0 ? 0 : n % 10 + SumOfDigits(n / 10);            
        }
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sum digits = {SumOfDigits(n)}");
        }
    }
}
