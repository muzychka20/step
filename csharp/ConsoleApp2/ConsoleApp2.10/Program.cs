/*
Задание 3
Создайте класс Circle, который будет представлять круг.
Класс должен содержать закрытое поле radius (радиус круга).
Реализуйте свойство для доступа к радиусу с проверкой, что значение не может быть меньше или равно нулю.
Добавьте конструктор для инициализации радиуса и метод GetArea, который возвращает площадь круга.
*/

using System;

namespace ConsoleApp2._10
{
    class Circle
    {
        private float radius;
        public float Radius
        {
            get { return radius; }
            set { if (value > 0) { radius = value; } }
        }

        public Circle(float radius)
        {            
            this.radius = radius > 0 ? radius : 1;
        } 

        public float GetArea()
        {
            return (float)(Math.PI * Math.Pow(radius, 2));
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(-4);
            Console.WriteLine("Area = " + circle.GetArea());
            circle.Radius = 0;
            Console.WriteLine("Area = " + circle.GetArea());
            circle.Radius = 5;
            Console.WriteLine("Area = " + circle.GetArea());
        }
    }
}
