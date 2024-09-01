/*
Задание 1
Описание: Напишите рекурсивную функцию GCD(Greatest Common Divisor), которая принимает два целых числа и возвращает их наибольший общий делитель, используя алгоритм Евклида.
Требования:
Реализуйте функцию с использованием рекурсии.
Обработайте случай, когда одно из чисел равно нулю.
*/

using System;

namespace ConsoleApp2
{
    class Program
    {
        public static int GCD(int a, int b)
        {
            return b == 0 ? Math.Abs(a) : GCD(b, a % b);
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"GCD(0, 5) = {GCD(0, 5)}");
            Console.WriteLine($"GCD(15, 5) = {GCD(6, 15)}");
        }
    }
}
