/*
Создайте консольное приложение, которое моделирует фабрику создания транспорта.
Приложение должно уметь создавать различные виды транспорта (например, автомобиль, велосипед, грузовик)
с использованием паттерна Factory Method.

Требования:
Создайте базовый интерфейс ITransport, представляющий общий функционал всех видов транспорта.
Реализуйте несколько классов транспорта (например, Car, Bike, Truck), наследующихся от интерфейса ITransport.
Создайте фабрику (TransportFactory) с методом, который возвращает нужный тип транспорта в зависимости от переданного параметра.
В основной программе вызовите фабрику для создания разных видов транспорта и выведите информацию о каждом из них.
*/

public interface ITransport
{
	public abstract void Move();
}

public class Car : ITransport
{
	public void Move()
	{
		Console.WriteLine($"Car is moving!");
	}
}

public class Bike : ITransport
{
	public void Move()
	{
		Console.WriteLine($"Bike is moving!");
	}
}

public class Truck : ITransport
{
	public void Move()
	{
		Console.WriteLine($"Truck is moving!");
	}
}

public static class TransportFactory
{	
	public static ITransport CreateTransport(string type)
	{
		return type switch
		{
			"car" => new Car(),
			"bike" => new Bike(),
			"truck" => new Truck(),
			_ => throw new ArgumentException("Invalid type!"),
		};
	}
}

class Program
{
	static void Main()
	{
		try
		{
			Console.WriteLine("Input type (car, bike, truck): ");
			string type = Console.ReadLine();

			ITransport transport = TransportFactory.CreateTransport(type);
			transport.Move();
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}
}