/*
Задание 2
Создайте перечисление Month, представляющее все месяцы года.
Напишите функцию GetSeason, которая принимает значение этого перечисления и возвращает строку,
представляющую сезон года (Winter, Spring, Summer, Autumn).
*/

using System;

namespace ConsoleApp2._5
{
    enum Month 
    {
        January,    
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    class Program
    {
        static string GetSeason(int month)
        {
            month--;
            if (month >= 0 && month <= 11)
            {

                if (month >= 2 && month <= 4)
                {
                    return "Spring";
                }
                else if (month >= 5 && month <= 7)
                {
                    return "Summer";
                }
                else if (month >= 8 && month <= 10)
                {
                    return "Autumn";
                }
                else
                {
                    return "Winter";
                }
            }
            else
            {
                return "Unknown";
            }
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine($"{i+1}) {(Month)i}");
            }
            Console.Write("\nMonth Number = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSeason(n));
        }
    }
}
