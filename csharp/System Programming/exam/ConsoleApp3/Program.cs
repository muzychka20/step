// Напишите программу, которая выполняет 10 параллельных вычислений,
// каждое из которых состоит в суммировании чисел от 1 до 10000 (в каждом потоке).
// Используйте класс Task для управления потоками. После завершения всех задач выведите сумму всех результатов.

class Exam
{
	static void Main(string[] args)
	{
		List<Task<int>> tasks = new List<Task<int>>();

		for(int i = 0; i < 10; i++)
		{
			var task = Task.Factory.StartNew(() =>
			{
				return GetSum();
			});
			tasks.Add(task);
		}

		Task.WhenAll(tasks).Wait();

		int total = 0;
		foreach (var task in tasks)
		{
			total += task.Result;
		}
		Console.WriteLine($"Total: {total}");
	}

	static int GetSum()
	{
		int sum = 0;
		for (int i = 1; i <= 10000; i++)
		{
			sum += i;
		}
		Console.WriteLine(sum);		
		return sum;
	}
}