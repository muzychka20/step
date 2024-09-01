/*
Задание 4
Описание: Напишите функцию IsEven, которая принимает целое число и возвращает true, если число четное, и false — если нечетное.
Требования:
Реализуйте простую проверку с использованием оператора %.
Обеспечьте корректную работу функции для всех целых чисел, включая ноль.
*/

using System;

namespace ConsoleApp2._3
{
    class Program
    {
        static bool IsEven(int n)
        {            
            return n % 2 == 0;
        }

        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            
            if (IsEven(n)) Console.WriteLine("n is even");
            else Console.WriteLine("n is odd");
        }
    }
}
