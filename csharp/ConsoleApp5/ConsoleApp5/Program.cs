/*
Задание 1

Разработать абстрактный класс ГеометрическаяФигура с полями ПлощадьФигуры и ПериметрФигуры.
Разработать классы-наследники: Треугольник, Квадрат, Ромб, Прямоугольник, Параллелограмм,
Трапеция, Круг, Эллипс и реализовать свойства, которые однозначно определяют объекты данных классов.

Предусмотреть варианты невозможности задания фигуры
(введены отрицательные длины сторон или при создании объекта треугольника существует пара сторон,
сумма длин которых меньше длины третьей стороны и т.п.)


Реализовать интерфейс ПростойНУгольник, который имеет свойства:
Высота, Основание, УголМеждуОснованиемИСмежнойСтороной, КоличествоСторон, ДлиныСторон, Площадь, Периметр.

Реализовать класс СоставнаяФигура который может состоять из любого количества ПростыхНУгольников.
Для данного класса определить метод нахождения площади фигуры.
*/

using System;

/*public interface ISimpleNFigure
{
    public double Height { get; set; }
    public double Base { get; set; }
    public double Alpha { get; set; }
    public double SideAmount { get; set; }
    public List<double> LengthSides { get; set; }
    public double Area { get; set; }
    public double Perimeter { get; set; }
}*/

public class CompositeFigure
{
    private List<GeometricFigure> _components;

    public CompositeFigure()
    {
        _components = new List<GeometricFigure>();
    }

    public void AddFigure(GeometricFigure figure)
    {
        _components.Add(figure);
    }

    public double TotalArea()
    {
        return _components.Sum(f => f.AreaFigure);
    }

    public override string ToString()
    {
        return $"Composite Figure with {_components.Count} components has Total Area = {TotalArea()}";
    }
}

public abstract class GeometricFigure
{
    public abstract double AreaFigure { get; }
    public abstract double PerimeterFigure { get; }
}

public class Triangle : GeometricFigure
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new ArgumentException("Side lengths must be positive.");
        if (a + b <= c || a + c <= b || b + c <= a)
            throw new ArgumentException("The sum of any two sides must be greater than the third side.");

        A = a;
        B = b;
        C = c;
    }

    public override double AreaFigure
    {
        get
        {
            double p = PerimeterFigure / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
    public override double PerimeterFigure => A + B + C;

    public override string ToString()
    {
        return $"Triangle: A = {A}, B = {B}, C = {C}, Perimeter = {PerimeterFigure}, Area = {AreaFigure}";
    }
}

public class Square : GeometricFigure
{
    public double A { get; }

    public Square(double a)
    {
        if (a <= 0)
            throw new ArgumentException("Side length must be positive.");

        A = a;
    }

    public override double AreaFigure => Math.Pow(A, 2);
    public override double PerimeterFigure => 4 * A;

    public override string ToString()
    {
        return $"Square: A = {A}, Perimeter = {PerimeterFigure}, Area = {AreaFigure}";
    }
}

public class Diamond : GeometricFigure
{
    public double Diagonal1 { get; }
    public double Diagonal2 { get; }

    public Diamond(double diagonal1, double diagonal2)
    {
        if (diagonal1 <= 0 || diagonal2 <= 0)
            throw new ArgumentException("Diagonals must be positive.");

        Diagonal1 = diagonal1;
        Diagonal2 = diagonal2;
    }

    public override double AreaFigure => (Diagonal1 * Diagonal2) / 2;
    public override double PerimeterFigure => 2 * Math.Sqrt(Math.Pow(Diagonal1, 2) + Math.Pow(Diagonal2, 2));

    public override string ToString()
    {
        return $"Diamond: Diagonal1 = {Diagonal1}, Diagonal2 = {Diagonal2}, Perimeter = {PerimeterFigure}, Area = {AreaFigure}";
    }
}

public class Rectangle : GeometricFigure
{
    public double A { get; }
    public double B { get; }

    public Rectangle(double a, double b)
    {
        if (a <= 0 || b <= 0)
            throw new ArgumentException("Side lengths must be positive.");

        A = a;
        B = b;
    }

    public override double AreaFigure => A * B;
    public override double PerimeterFigure => 2 * (A + B);

    public override string ToString()
    {
        return $"Rectangle: A = {A}, B = {B}, Perimeter = {PerimeterFigure}, Area = {AreaFigure}";
    }
}

public class Parallelogram : GeometricFigure
{
    public double Base { get; }
    public double SideLength { get; }
    public double Height { get; }

    public Parallelogram(double _base, double _sideLength, double _height)
    {
        if (_base <= 0 || _sideLength <= 0 || _height <= 0)
            throw new ArgumentException("Base, side length, and height must be positive.");

        Base = _base;
        SideLength = _sideLength;
        Height = _height;
    }

    public override double AreaFigure => Base * Height;
    public override double PerimeterFigure => 2 * (SideLength + Base);

    public override string ToString()
    {
        return $"Parallelogram: Base = {Base}, Side Length = {SideLength}, Height = {Height}, Perimeter = {PerimeterFigure}, Area = {AreaFigure}";
    }
}

public class Trapezoid : GeometricFigure
{
    public double Base1 { get; }
    public double Base2 { get; }
    public double SideLength1 { get; }
    public double SideLength2 { get; }
    public double Height { get; }

    public Trapezoid(double _base1, double _base2, double _side1, double _side2, double _height)
    {
        if (_base1 <= 0 || _base2 <= 0 || _side1 <= 0 || _side2 <= 0 || _height <= 0)
            throw new ArgumentException("Base lengths, side lengths, and height must be positive.");

        Base1 = _base1;
        Base2 = _base2;
        SideLength1 = _side1;
        SideLength2 = _side2;
        Height = _height;
    }

    public override double AreaFigure => ((Base1 + Base2) / 2) * Height;
    public override double PerimeterFigure => Base1 + Base2 + SideLength1 + SideLength2;

    public override string ToString()
    {
        return $"Trapezoid: Base1 = {Base1}, Base2 = {Base2}, Side Length1 = {SideLength1}, Side Length2 = {SideLength2}, Height = {Height}, Perimeter = {PerimeterFigure}, Area = {AreaFigure}";
    }
}

public class Circle : GeometricFigure
{
    public double Radius;

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius must be positive.");

        Radius = radius;
    }

    public override double AreaFigure => Math.PI * Math.Pow(Radius, 2);
    public override double PerimeterFigure => 2 * Math.PI * Radius;

    public override string ToString()
    {
        return $"Circle: Radius = {Radius}, Perimeter = {PerimeterFigure}, Area = {AreaFigure}";
    }
}

class Ellipse : GeometricFigure
{
    public double MajorAxis { get; }
    public double MinorAxis { get; }

    public Ellipse(double majorAxis, double minorAxis)
    {
        if (majorAxis <= 0 || minorAxis <= 0)
            throw new ArgumentException("Axes must be positive.");

        MajorAxis = majorAxis;
        MinorAxis = minorAxis;
    }

    public override double PerimeterFigure => 2 * Math.PI * Math.Sqrt((MajorAxis * MajorAxis + MinorAxis * MinorAxis) / 2);
    public override double AreaFigure => Math.PI * MajorAxis * MinorAxis;

    public override string ToString()
    {
        return $"Ellipse: Major Axis = {MajorAxis}, Minor Axis = {MinorAxis}, Perimeter = {PerimeterFigure}, Area = {AreaFigure}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<GeometricFigure> figures = new List<GeometricFigure>
            {
                    new Triangle(3, 4, 5),
                    new Square(5),
                    new Diamond(4, 6),
                    new Rectangle(4, 6),
                    new Parallelogram(5, 3, 4),
                    new Trapezoid(3, 4, 5, 2, 3),
                    new Circle(3),
                    new Ellipse(5, 3),
            };

            Console.WriteLine("SimpleNFigure consists of:\n");
            
            CompositeFigure compositeFigure = new CompositeFigure();
            
            foreach (var figure in figures)
            {
                Console.WriteLine($"{figure.ToString()}\n");
                compositeFigure.AddFigure(figure);
            }

            Console.WriteLine(compositeFigure.ToString());
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}
