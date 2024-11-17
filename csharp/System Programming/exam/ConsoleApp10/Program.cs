/*
10. Реализация очереди с многократным доступом с помощью ConcurrentQueue и потоков
Задание:
Напишите программу, которая создает два потока: 
один добавляет элементы в очередь ConcurrentQueue<int>, 
а второй — извлекает элементы из этой очереди и выводит их на экран. 
Поток добавления должен добавлять числа от 1 до 10, 
а поток извлечения должен выводить эти числа. 
Обеспечьте синхронизацию между потоками, 
используя только примитивы синхронизации ConcurrentQueue.
*/

using System.Collections.Concurrent;

class Exam
{
	static async Task Main()
	{
		ConcurrentQueue<int> queue = new ConcurrentQueue<int>();
		
		
		Thread thread1 = new Thread(() => {
			for (int i = 0; i < 10; i++)
			{
				queue.Enqueue(i);
				Console.WriteLine($"{i} added");
				Thread.Sleep(1000);
			}
		});

		Thread thread2 = new Thread(() => {
			while (queue.TryDequeue(out int result))
			{
				Console.WriteLine($"{result} deleted");
				Thread.Sleep(2000);
			}
		});
		
		thread1.Start();
		thread2.Start();

		thread1.Join();
		thread2.Join();	
	}
}