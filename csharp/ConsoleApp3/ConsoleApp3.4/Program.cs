using System;

namespace ConsoleApp3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape square = new Square(2, 5);
            Console.WriteLine("Square: ");
            Console.WriteLine($"Area: {square.CalculateArea()}");
            Console.WriteLine($"Perimeter: {square.CalculatePerimeter()}");

            Console.WriteLine("-------------------------------");

            Shape triangle = new Triangle(3, 4, 5);
            Console.WriteLine("Triangle: ");
            Console.WriteLine($"Area: {triangle.CalculateArea()}");
            Console.WriteLine($"Perimeter: {triangle.CalculatePerimeter()}");

            Console.WriteLine("-------------------------------");

            Shape circle = new Circle(3);
            Console.WriteLine("Circle: ");
            Console.WriteLine($"Area: {circle.CalculateArea()}");
            Console.WriteLine($"Perimeter: {circle.CalculatePerimeter()}");
        }
    }
}
