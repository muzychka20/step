//Напишите консольное приложение, которое запускает 5 потоков,
//каждый из которых выводит на экран сообщение с задержкой в 1 секунду.
//После завершения работы всех потоков выведите на экран "Все потоки завершены".
class Exam
{
	static void Main()
	{
		List<Thread> threads = new List<Thread>();
		for (int i = 0; i < 5; i++)
		{ 
			Thread thread = new Thread(() => { PrintLine(i); }); 
			threads.Add(thread);
			thread.Start();
			Thread.Sleep(1000);
		}
		
		foreach(Thread thread in threads)
		{
			thread.Join();
		}				
	}

	public static void PrintLine(int index)
	{
		Console.WriteLine($"Thread {index} with id: {Thread.CurrentThread.ManagedThreadId}");
	}
}