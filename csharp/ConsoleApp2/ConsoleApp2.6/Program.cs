/*
Задание 3
Создайте перечисление Color с несколькими значениями (Red, Green, Blue, Yellow).
Напишите функцию ColorToString, которая принимает значение этого перечисления и возвращает его строковое представление.
*/

using System;

namespace ConsoleApp2._6
{
    enum Color
    {
        Red,
        Green,
        Blue,
        Yellow,
        Size
    }

    class Program
    {
        static string ColorToString(int color)
        {
            if (!(color >= 0 && color < (int)Color.Size)) return "Unknown";
            Color c = (Color)color;
            return c.ToString();
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < (int)Color.Size; i++)
            {
                Console.WriteLine($"{i + 1}) {(Color)i}");
            }
            Console.Write("\nMonth Number = ");
            int n = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine(ColorToString(n));
        }
    }
}
