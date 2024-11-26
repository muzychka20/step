/*Реализуйте консольное приложение, которое создает объекты пиццы (класс Pizza) с различными ингредиентами с использованием паттерна Builder. Каждый объект пиццы должен включать:

Основание(например, тонкое или толстое тесто).
Тип сыра.
Тип соуса.
Дополнительные ингредиенты(например, помидоры, грибы, пепперони и т.д.).
Требования:

Создайте класс Pizza, представляющий готовую пиццу.
Используйте паттерн Builder для создания объектов пиццы.
В основной программе создайте несколько вариантов пиццы с разным набором ингредиентов и выведите их описание в консоль.*/


using System.IO;

public class Pizza
{
	public string Crust { get; set; } = string.Empty;
	public string CheeseType { get; set; } = string.Empty;
	public string SauceType { get; set; } = string.Empty;
	public List<string>? Extra { get; set; } = null;

	public override string ToString()
	{
		string res = $"Crust: {Crust}; CheeseType: {CheeseType}; SauceType: {SauceType}; Extra: ";
		if (Extra != null)
		foreach (var el in Extra)
		{
			res += el + " ";
		}
		return res;
	}
}

public interface ICookingPizza
{
	void MakeCrust();
	void MakeCheeseType();
	void MakeSauceType();
	void MakeExtra();
	Pizza GetPizza();
}

public class PepperoniPizzaBuilder : ICookingPizza
{
	Pizza pizza = new Pizza();

	public Pizza GetPizza()
	{
		return pizza;		
	}

	public void MakeCheeseType()
	{
		pizza.CheeseType = "Pepperoni chhese";
	}

	public void MakeCrust()
	{
		pizza.Crust = "Pepperoni crust";
	}

	public void MakeExtra()
	{
		pizza.Extra = new List<string>();
		pizza.Extra.Add("Pepperoni extra 1");
		pizza.Extra.Add("Pepperoni extra 2");
		pizza.Extra.Add("Pepperoni extra 3");
	}

	public void MakeSauceType()
	{
		pizza.SauceType = "Pepperoni sauce";
	}
}

public class HawaiianPizzaBuilder : ICookingPizza
{
	Pizza pizza = new Pizza();

	public Pizza GetPizza()
	{
		return pizza;
	}

	public void MakeCheeseType()
	{
		pizza.CheeseType = "Mozzarella";
	}

	public void MakeCrust()
	{
		pizza.Crust = "Traditional crust";
	}

	public void MakeExtra()
	{
		pizza.Extra = new List<string>();
		pizza.Extra.Add("Pineapple");
		pizza.Extra.Add("Ham");
		pizza.Extra.Add("Sweet Corn");
	}

	public void MakeSauceType()
	{
		pizza.SauceType = "Tomato sauce";
	}
}

public class Kitchen
{
	ICookingPizza? cookingPizza;

	public void SetBuilder(ICookingPizza builder)
	{
		cookingPizza = builder;
	}

	public void Cook()
	{
		cookingPizza?.MakeCrust();
		cookingPizza?.MakeSauceType();
		cookingPizza?.MakeCheeseType();
		cookingPizza?.MakeExtra();
	}
}

class Program
{
	static void Main()
	{
		Pizza pizza;

		var kitchen = new Kitchen();
		var builder1 = new PepperoniPizzaBuilder();
		var builder2 = new HawaiianPizzaBuilder();

		kitchen.SetBuilder(builder1);
		kitchen.Cook();
		pizza = builder1.GetPizza();
		Console.WriteLine(pizza);

		kitchen.SetBuilder(builder2);
		kitchen.Cook();
		pizza = builder2.GetPizza();
		Console.WriteLine(pizza);
	}
}