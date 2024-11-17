//Напишите консольное приложение, которое выполняет две асинхронные операции:
//одна возвращает число через 2 секунды, другая — через 3 секунды.
//После завершения обеих операций выведите их результаты на экран.
class Exam
{
	static async Task Main()
	{
		int n1 = await GetNumber(2);
		int n2 = await GetNumber(3);		
		Console.WriteLine(n1);
		Console.WriteLine(n2);
	}

	public static async Task<int> GetNumber(int n)
	{
		Random rand = new Random();
		await Task.Delay(n * 1000);
		return rand.Next();
	}
}