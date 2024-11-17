/*
8.Работа с параллельными вычислениями с использованием Parallel.For
Задание:
Напишите программу, которая выполняет параллельную обработку массива чисел от 1 до 1000 
с использованием Parallel.For. Каждое число в массиве должно быть умножено на 2. 
Выведите на экран измененные элементы массива.
*/


using System;
using System.Threading.Tasks;

class Exam
{
	static void Main()
	{
		int[] numbers = new int[1000];

		for (int i = 0; i < numbers.Length; i++)
		{
			numbers[i] = i + 1;
		}

		Parallel.For(0, numbers.Length, i =>
		{
			numbers[i] *= 2;
		});

		for (int i = 0; i < numbers.Length; i++)
		{
			Console.WriteLine(numbers[i]);
		}				
	}
}