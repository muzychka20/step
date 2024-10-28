using System.Text;
using System.Diagnostics;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

//Задача №1
//Создайте поток, который "принимает" в себя коллекцию элементов,
//и вызывает из каждого элемента коллекции метод ToString() 
//и выводит результат работы метода на экран. 

/*
List<object> items = new List<object> { 123, "Hello", DateTime.Now, 45.67 };

Thread thread = new Thread(() => PrintCollection(items));
thread.Start();

thread.Join();
Console.WriteLine("Thread is done.");

static void PrintCollection(List<object> collection)
{
	foreach (var item in collection)
	{
		Console.WriteLine(item.ToString());
	}
}
*/

//Задача № 2. 
//Создайте класс Bank, в котором будут следующие
//свойства: int money, string name, int percent. 
//Постройте класс так, чтобы при изменении одного из свойств,
//класса создавался новый поток, который записывал
//данные о свойствах класса в текстовый файл 
//на жестком диске. Класс должен инкапсулировать в себе всю
//логику многопоточности.

/*
class Bank
{
	private int _money;
	private string _name;
	private int _percent;
	private readonly string _filePath = "BankData.txt";
	
	public int Money
	{
		get => _money;
		set
		{
			_money = value;
			LogChange();
		}
	}

	public string Name
	{
		get => _name;
		set
		{
			_name = value;
			LogChange();
		}
	}

	public int Percent
	{
		get => _percent;
		set
		{
			_percent = value;
			LogChange();
		}
	}
	
	private void LogChange()
	{		
		Thread logThread = new Thread(() =>
		{
			WriteToFile();
		});
		logThread.Start();
	}
	
	private void WriteToFile()
	{		
		lock (this)
		{
			using (StreamWriter writer = new StreamWriter(_filePath, true))
			{
				writer.WriteLine($"Date: {DateTime.Now}");
				writer.WriteLine($"Name: {_name}");
				writer.WriteLine($"Money: {_money}");
				writer.WriteLine($"Percent: {_percent}");
				writer.WriteLine(new string('-', 20));
			}
		}
	}
}

class Program
{
	static void Main(string[] args)
	{
		Bank bank = new Bank
		{
			Name = "Bank of Trust",
			Money = 100000,
			Percent = 5
		};
		
		Thread.Sleep(5000);
		bank.Money = 120000;

		Thread.Sleep(5000);
		bank.Percent = 6;	

		Thread.Sleep(5000);
		bank.Name = "Trustworthy Bank";
		
		Console.WriteLine("Modifications are writed to file!");
	}
}
*/

//Задача 3. Реализуйте консольное игровое приложение "успел,
//не успел", где будет проверяться скорость реакции
//пользователя. Программа должна подать сигнал
//пользователю в виде текста, и пользователю должен
//будет нажать кнопку на клавиатуре, после нажатия
//пользователь должен увидеть, сколько миллисекунд
//ему потребовалось, чтобы нажать кнопку. 


Console.WriteLine("Добро пожаловать в игру 'Успел, не успел'!");
Console.WriteLine("Подготовьтесь, через несколько секунд появится сигнал.");
Thread.Sleep(new Random().Next(2000, 5000));

Console.WriteLine("Нажмите Enter как можно быстрее!");
Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }

stopwatch.Stop();
Console.WriteLine($"Ваше время реакции: {stopwatch.ElapsedMilliseconds} миллисекунд.");

if (stopwatch.ElapsedMilliseconds <= 300)
{
	Console.WriteLine("Отличная реакция! Вы успели!");
}
else if (stopwatch.ElapsedMilliseconds <= 700)
{
	Console.WriteLine("Хорошая реакция! Можно еще лучше!");
}
else
{
	Console.WriteLine("Слишком медленно, попробуйте еще раз.");
}

Console.WriteLine("Спасибо за игру!");
