/*
Задание 1
Создайте перечисление DayOfWeek, представляющее дни недели (Monday, Tuesday, Wednesday и т.д.). 
Напишите функцию IsWeekend, которая принимает значение этого перечисления и возвращает true, 
если день является выходным (суббота или воскресенье), и false в противном случае.
*/

using System;

namespace ConsoleApp2._4
{
    class Program
    {
        enum DayOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        public static bool IsWeekend(int day)
        {
            return day == (int)DayOfWeek.Sunday || day == (int)DayOfWeek.Saturday;
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"{i}) {(DayOfWeek)i}");
            }
            Console.Write("\nDay Number = ");
            int n = int.Parse(Console.ReadLine());
            if (IsWeekend(n))
            {
                Console.Write("It is weekend!");
            }
            else
            {
                Console.Write("It is not weekend!");
            }
        }
    }
}
