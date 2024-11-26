/*
У вас есть старый класс Printer,
который умеет выводить текст только заглавными буквами.
Однако, приложение требует выводить текст в обычном формате.

Создайте адаптер, который позволит использовать Printer для вывода текста в обычном виде.
*/

public interface IPrinter
{
	public string Print(string message);
}

public class Printer
{
	public string PrintUpperCase(string message)
	{
		return message.ToUpper();
	}
}

public class PrinterAdapter : IPrinter
{
	private readonly Printer _printer;

	public PrinterAdapter(Printer printer)
	{
		_printer = printer;
	}

	public string Print(string message)
	{
		return _printer.PrintUpperCase(message).ToLower();
	}
}


class Program
{
	static void Main()
	{
		Printer old = new Printer();
		Console.WriteLine(old.PrintUpperCase("hello"));

		IPrinter printer = new PrinterAdapter(old);
		Console.WriteLine(printer.Print("Hello, world!"));
	}
}