//Задание 4:
//Приложение генерирует случайным образом 10000 целых чисел.
//Необходимо сохранить чётные числа в один файл, нечётные в
//другой. По итогам работы приложения нужно отобразить
//статистику на экран.


using System.IO;
using System.Text;

class Files3
{
	static void Main()
	{
		List<int> evenNumbers = new List<int>();
		List<int> oddNumbers = new List<int>();

		for (int i = 0; i < 1000; i++)
		{
			Random random = new Random();
			int value = random.Next();
			if (value % 2 == 0)
			{
				evenNumbers.Add(value);
			}
			else
			{
				oddNumbers.Add(value);
			}
		}

		string filePathEven = "even.txt";
		using (FileStream fileStreamEven = new FileStream(filePathEven, FileMode.Create, FileAccess.Write))
		{
			foreach (var el in evenNumbers)
			{
				byte[] data = Encoding.UTF8.GetBytes(el + " ");
				fileStreamEven.Write(data, 0, data.Length);
			}
		}

		string filePathOdd = "odd.txt";
		using (FileStream fileStreamOdd = new FileStream(filePathOdd, FileMode.Create, FileAccess.Write))
		{
			foreach (var el in oddNumbers)
			{
				byte[] data = Encoding.UTF8.GetBytes(el + " ");
				fileStreamOdd.Write(data, 0, data.Length);
			}
		}

		Console.WriteLine($"Even count: {evenNumbers.Count}");
		Console.WriteLine($"Odd count: {oddNumbers.Count}");
	}
}
