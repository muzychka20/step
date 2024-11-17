/*
5. Использование Monitor для синхронизации
Задание:
Напишите программу, которая создает 3 потока.
Каждый поток должен поочередно захватывать и освобождать монитор 
для общего ресурса (например, строки), используя методы Monitor.Enter и Monitor.Exit.
Убедитесь, что потоки не выполняются одновременно.
Выведите на экран, в каком порядке выполнялись потоки.
*/


using System;
using System.Diagnostics.Metrics;
using System.Reflection;

class Exam
{
	private static readonly object monitorObject = new object();
	private static string str = "Threads order: ";
		
	static void Main()
	{

		Thread[] threads = new Thread[3];
		
		for (int i = 0; i < threads.Length; i++)
		{
			threads[i] = new Thread(ModifyStr);
			threads[i].Start();
		}

		foreach (var thread in threads)
		{
			thread.Join();
		}		

		Console.WriteLine(str);
	}

	static void ModifyStr()
	{
		Monitor.Enter(monitorObject);
		try
		{
			str += "  " + Thread.CurrentThread.ManagedThreadId.ToString();			
		}
		finally
		{
			Monitor.Exit(monitorObject);
		}		
	}
}