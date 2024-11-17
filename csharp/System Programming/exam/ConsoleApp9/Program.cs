/*
9. Приложение считывает набор чисел с плавающей точкой из файла в список. Необходимо:
Посчитать квадратный корень каждого числа.
Результаты сохранить в отдельный файл.
Для решения задачи используйте метод Parallel.ForEach.
*/

using System.Collections.Concurrent;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Exam
{
	static async Task Main()
	{		
		var x = new ConcurrentBag<double>();
		string path = "file.txt";
		var lines = await File.ReadAllLinesAsync(path);

		Parallel.ForEach(lines, line =>
		{
			if (Double.TryParse((line), out double number))
			{
				x.Add(Math.Sqrt(number));
				Console.WriteLine(line);
			}			
		});
		
		await File.WriteAllLinesAsync("newFile.txt", x.Select(n => n.ToString()));	
	}	
}