using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

class Program
{
	static ConcurrentDictionary<string, int> pageVisits = new ConcurrentDictionary<string, int>();

	static void Main()
	{
		var tasks = new Task[10];
		for (int i = 0; i < tasks.Length; i++)
		{
			int taskIndex = i;
			tasks[i] = Task.Run(() => AddPageVisit($"url{taskIndex}"));
		}

		var readTask = Task.Run(() => ReadPageVisits());

		Task.WhenAll(tasks.Concat(new[] { readTask })).Wait();

		Console.WriteLine("Done!");

		Console.WriteLine("Fin:");
		foreach (var kvp in pageVisits)
		{
			Console.WriteLine($"{kvp.Key}: {kvp.Value}");
		}

	}

	static void AddPageVisit(string url)
	{
		Random rnd = new Random();
		for (int i = 0; i < 100; i++)
		{
			pageVisits.AddOrUpdate(url, 1, (key, oldValue) => oldValue + rnd.Next(1, 10));
			Thread.Sleep(50);
		}
	}

	static void ReadPageVisits()
	{
		for (int i = 0; i < 5; i++)
		{
			Console.WriteLine("Current:");
			foreach (var kvp in pageVisits)
			{
				Console.WriteLine($"{kvp.Key}: {kvp.Value}");
			}
			Thread.Sleep(500);
		}
	}
}
