namespace Quiz
{
	public class QuizService
	{	
		private List<Quiz> quizzes = new List<Quiz>
		{
			new Quiz
			{
				Name = "История",
				Questions = new List<Question>
				{
					new Question
					{
						Text = "Когда началась Первая мировая война?",
						Options = new List<string> { "1912", "1914", "1916", "1918" },
						CorrectAnswers = new List<int> { 2 }
					},
					new Question
					{
						Text = "Кто был первым президентом США?",
						Options = new List<string> { "Авраам Линкольн", "Джордж Вашингтон", "Томас Джефферсон", "Теодор Рузвельт" },
						CorrectAnswers = new List<int> { 2 }
					},
					new Question{
						Text = "Какие из следующих государств являются постоянными членами Совета Безопасности ООН?",
						Options = new List<string> { "Франция", "Германия", "Китай", "Индия", "Россия", "США" },
						CorrectAnswers = new List<int> { 1, 3, 5, 6 } // Франция, Китай, Россия, США
					}
				}
			},
			new Quiz
			{
				Name = "География",
				Questions = new List<Question>
				{
					new Question
					{
						Text = "Какая самая большая страна по площади?",
						Options = new List<string> { "Канада", "Россия", "Китай", "США" },
						CorrectAnswers = new List<int> { 2 }
					},
					new Question
					{
						Text = "Какой океан самый большой?",
						Options = new List<string> { "Атлантический", "Тихий", "Индийский", "Северный Ледовитый" },
						CorrectAnswers = new List<int> { 2 }
					}
				}
			}
		};		
		
		public void TakeQuiz()
		{
			Console.WriteLine("Выберите викторину:");
			for (int i = 0; i < quizzes.Count; i++)
			{
				Console.WriteLine($"{i + 1}. {quizzes[i].Name}");
			}
			int choose = Int32.Parse(Console.ReadLine()) - 1;

			if (choose < quizzes.Count && choose >= 0)
			{
				int countCorrectAnswers = 0;
				var selectedQuiz = quizzes[choose];
				Console.WriteLine($"Начата викторина: {selectedQuiz.Name}");

				foreach (var question in selectedQuiz.Questions)
				{
					Console.WriteLine(question.Text);
					for (int j = 0; j < question.Options.Count; j++)
					{
						Console.WriteLine($"{j + 1}. {question.Options[j]}");
					}

					Console.WriteLine("Введите номера правильных ответов через запятую (например, 1,3): ");
					var ans = Console.ReadLine().Split(',').Select(a => int.Parse(a.Trim())).ToList();

					if (ans.OrderBy(a => a).SequenceEqual(question.CorrectAnswers.OrderBy(a => a)))
					{
						countCorrectAnswers++;
					}
				}

				var result = new QuizResult
				{
					QuizName = selectedQuiz.Name,
					CorrectAnswers = countCorrectAnswers,
					Date = DateTime.Now
				};

				result.ToString();
				UserStore.GetCurrentUser().QuizResults.Add(result);
			}
		}		
	}
}