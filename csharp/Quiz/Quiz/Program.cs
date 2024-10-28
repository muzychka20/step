using Quiz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quiz
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			Console.InputEncoding = Encoding.UTF8;
			UserRepository userRepository = new UserRepository();
			MainMenu mainMenu = new MainMenu(userRepository);
			mainMenu.Show();
		}
	}
}