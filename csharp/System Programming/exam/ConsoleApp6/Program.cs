/*
6. Реализация блокировки с использованием SemaphoreSlim
Задание:
Создайте программу, которая имитирует работу 10 потоков, каждый из которых 
выполняет некоторую операцию с задержкой в 1 секунду. 
Используйте SemaphoreSlim для того, чтобы одновременно выполнялось не более 3 потоков.
После завершения работы всех потоков выведите "Все потоки завершены".
*/

class Exam
{
	private static SemaphoreSlim semaphore = new SemaphoreSlim(3);
	static void Main()
	{
		Thread[] threads = new Thread[10];
		for (int i = 0; i < 10; i++)
		{
			Thread thread = new Thread(Work);
			thread.Name = $"Thread {i + 1}";
			threads[i] = thread;
			thread.Start();
		}		
		foreach (var thread in threads)
		{
			thread.Join();
		}
	}

	static void Work()
	{		
		semaphore.Wait();
		try
		{			
			Console.WriteLine($"{Thread.CurrentThread.Name} is working!");
			Thread.Sleep(2000);
		}
		finally
		{		
			Console.WriteLine($"{Thread.CurrentThread.Name} releases access to the resource.");
			semaphore.Release();
		}
	}

}