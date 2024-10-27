namespace Quiz
{
	public class QuizResult
	{
		public string QuizName { get; set; }
		public int CorrectAnswers { get; set; }
		public DateTime Date { get; set; }
		public void ToString()
		{
			Console.WriteLine($"QuizName: {QuizName}");
			Console.WriteLine($"Correct Answers: {CorrectAnswers}");
			Console.WriteLine($"Date: {Date}");
			Console.WriteLine("----------------------------------");
		}
	}
}