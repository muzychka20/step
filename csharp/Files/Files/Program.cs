//Задание 1:
//Приложение позволяет пользователю просматривать
//содержимое файла. Пользователь вводит путь к файлу. Если
//файл существует, его содержимое отображается на экран. Если
//файла не существует, нужно отобразить сообщение об ошибке.


class Files
{
	static void Main(string[] args)
	{
		// string filePath = args[0];
		while (true)
		{
			Console.WriteLine("Write path and name of the file: ");
			string filePath = Console.ReadLine();

			if (filePath == "quit")
				break;

			// Проверяем, существует ли файл
			if (File.Exists(filePath))
			{
				// Создание FileStream для чтения данных из файла
				using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
				{
					// Создание буфера для хранения данных из файла
					byte[] buffer = new byte[fileStream.Length];

					// Чтение данных из файла
					fileStream.Read(buffer, 0, buffer.Length);

					// Преобразование байтов в строку
					string fileContent = System.Text.Encoding.UTF8.GetString(buffer);
					Console.WriteLine("File Content: " + fileContent);
				}
			}
			else
			{
				Console.WriteLine("File not found.");
			}
		}

	}
}