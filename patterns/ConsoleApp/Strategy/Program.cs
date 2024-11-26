/*Создайте консольное приложение, которое рассчитывает стоимость доставки товаров в зависимости от выбранной стратегии доставки.

Условие:

У вас есть три способа доставки:

Курьерская доставка: фиксированная стоимость 50 у.е.
Доставка почтой: 20 у.е. + 5 у.е.за каждый килограмм.
Экспресс-доставка: 100 у.е., независимо от веса.
Приложение должно:

Спросить у пользователя вес посылки.
Предложить на выбор три варианта доставки.
Рассчитать и вывести стоимость доставки, используя соответствующую стратегию.*/

public interface IDelivery
{
	double СalculatePriceDelivery(double weight = 0);
}


public class CourierDelivery : IDelivery
{
	public double СalculatePriceDelivery(double weight = 0)
	{
		return 50.0;
	}
}

public class ExpressDelivery : IDelivery
{
	public double СalculatePriceDelivery(double weight = 0)
	{
		return 100.0;
	}
}

public class MailDelivery : IDelivery
{
	public double СalculatePriceDelivery(double weight = 0)
	{
		return 20.0 + weight * 5.0;
	}
}

public class DeliveryCostCalculator
{
	private IDelivery? _strategy;

	public void SetStrategy(IDelivery strategy)
	{
		_strategy = strategy;
	}

	public double CalculateCost(double weight)
	{
		if (_strategy == null)
			throw new InvalidOperationException("Stratehy is null!");
		return _strategy.СalculatePriceDelivery(weight);
	}
}

class Program
{
	static void Main()
	{
		Console.WriteLine("Enter Weight: "); double weight = Double.Parse(Console.ReadLine());
		Console.WriteLine("1. Courier Delivery");
		Console.WriteLine("2. Express Delivery");
		Console.WriteLine("3. Mail Delivery");
		Console.WriteLine("Enter Type Delivery: "); int type = Int32.Parse(Console.ReadLine());

		var deliveryCalculator = new DeliveryCostCalculator();


		switch (type)
		{
			case 1:
				deliveryCalculator.SetStrategy(new CourierDelivery());
				break;
			case 2:
				deliveryCalculator.SetStrategy(new ExpressDelivery());
				break;
			case 3:
				deliveryCalculator.SetStrategy(new MailDelivery());
				break;
			default:
				Console.WriteLine("Not exists!");
				break;
		}

		var result = deliveryCalculator.CalculateCost(weight);

		Console.WriteLine($"Your bill: {result}");
	}
}