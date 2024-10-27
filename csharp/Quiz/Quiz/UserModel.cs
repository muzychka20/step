using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
	public class UserModel
	{
		public string Id { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }
		public DateTime Birthday { get; set; }
		public int Points 
		{ 
			get
			{
				return QuizResults.Sum(x => x.CorrectAnswers);
			}			
		}
		public List<QuizResult> QuizResults { get; set; } = new List<QuizResult>();
		public void ToString()
		{
			Console.WriteLine($"Id: {Id}");
			Console.WriteLine($"Login: {Login}");
			Console.WriteLine($"Password: {Password}");
			Console.WriteLine($"Birthday: {Birthday}");
			Console.WriteLine($"Points: {Points}");
		}
	}
}
