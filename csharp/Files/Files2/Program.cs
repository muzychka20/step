//Задание 2:
//Пользователь вводит значения для элементов массива с
//клавиатуры. Приложение предоставляет возможность
//сохранения содержимого массива в файл.
//Задание 3:
//Добавьте ко второму заданию возможность загрузки массива из
//файла.


using System.IO;
using System.Text;

class Files2
{
	static void Main(string[] args)
	{
		while (true)
		{
			Console.WriteLine("1. Save file");
			Console.WriteLine("2. Read file");
			Console.WriteLine("3. Exit");

			int choose =  Int32.Parse(Console.ReadLine());

			if (choose == 3)
				break;

			switch (choose)
			{
				case 1:
					{
						SaveFile();
						break;
					}
				case 2:
					{
						OpenFile();
						break;
					}
			}			
		}
	}

	public static void SaveFile()
	{
		Console.WriteLine("Write file name: ");
		string filePath = Console.ReadLine();

		Console.WriteLine("Write content for file: ");
		List<string> contentArr = new List<string>();

		while (true)
		{
			string add = Console.ReadLine();
			if (add == "0")
				break;
			contentArr.Add(add);
		}

		using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
		{
			foreach (var el in contentArr)
			{
				byte[] data = Encoding.UTF8.GetBytes(el + Environment.NewLine);
				fileStream.Write(data, 0, data.Length);
			}
		}
		Console.WriteLine("Data successfully written to the file.");
	}


	public static void OpenFile()
	{
		List<string> contentArr = new List<string>();

		Console.WriteLine("Write file name: ");
		string filePath = Console.ReadLine();
				
		using (StreamReader sr = new StreamReader(filePath))
		{
			string line;
			while ((line = sr.ReadLine()) != null)
			{
				contentArr.Add(line);
			}
		}

		Console.WriteLine(contentArr.Count);

		foreach (var el in contentArr)
		{
			Console.WriteLine(el);
		}
	}
}