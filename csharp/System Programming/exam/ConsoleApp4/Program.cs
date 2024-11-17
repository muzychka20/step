/*
4.Синхронизация потоков с помощью lock
Задание:
Напишите программу, которая создает 5 потоков, каждый из которых выполняет инкремент общей переменной.
Для синхронизации доступа к общей переменной используйте ключевое слово lock.
После выполнения всех потоков выведите значение общей переменной.
*/


class Exam
{
	static readonly object lockObject = new object();

	static void Main()
	{
		List<Thread> threads = new List<Thread>();
		int total = 0;
		for (int i = 0; i < 5; i++)
		{
			var thread = new Thread(() => { 
				lock(lockObject)
				{
					for (int j = 0; j < 100; j++)
					{
						total++;
					}
				}
			});
			thread.Start();
			threads.Add(thread);
		}
		foreach (var thread in threads)
		{
			thread.Join(); 
		}
		Console.WriteLine(total);
	}
}