/*
7. Применение Task.WhenAll для ожидания завершения всех задач
Задание:
Напишите программу, которая выполняет 5 асинхронных операций,
каждая из которых задерживает выполнение на случайное количество времени от 1 до 5 секунд.
Используйте Task.WhenAll для ожидания завершения всех задач.
После завершения выведите на экран сообщение "Все операции завершены".
*/

class Exam
{	
	static async Task Main()
	{
		Task[] tasks = new Task[5];
		for (int i = 0; i < tasks.Length; i++)
		{
			tasks[i] = Work();
		}
		await Task.WhenAll(tasks);
	}

	static async Task Work()
	{
		Random rand = new Random();
		int n = rand.Next(1, 6);
		await Task.Delay(n * 1000);
		Console.WriteLine($"Has been working for {n} seconds");
	}
}