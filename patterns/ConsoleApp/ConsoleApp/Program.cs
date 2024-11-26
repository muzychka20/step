/*
Создайте консольное приложение, которое имитирует логирование событий. Используйте паттерн Singleton для класса Logger.

Требования:
Класс Logger должен быть реализован как Singleton.
У класса Logger должен быть метод Log(string message), который записывает переданное сообщение в файл log.txt.
В основной программе выполните запись нескольких сообщений через объект Logger и продемонстрируйте, что создается только один экземпляр Logger.
*/

using System.Text;

public class Logger
{
	private static Logger? _instance;
	private static readonly object _lock = new object();

	private Logger() { }

	public static Logger GetInstance()
	{
		if (_instance == null)
		{
			lock (_lock)
			{
				_instance = new Logger();
			}
		}
		return _instance;
	}

	public void Log(string message)
	{
		string filePath = "output.txt";

		using (StreamWriter sw = new StreamWriter(filePath, true))
		{			
			sw.WriteLine(message);
		}

		Console.WriteLine($"Сообщение '{message}' было записано в файл.");
	}
}


class Program
{
	static void Main()
	{
		Console.OutputEncoding = Encoding.UTF8;

		List<Logger> loggers = new List<Logger>();
		
		for (int i = 1; i <= 10; i++)
		{
			if (i % 2 == 0)
			{
				Logger logger = Logger.GetInstance();
				logger.Log($"{i} is even");
				loggers.Add(logger);
			}
		}

		Console.WriteLine(ReferenceEquals(loggers[0], loggers[1]) ? "Это один объект" : "Объекты разные");
	}
}