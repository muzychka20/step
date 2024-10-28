using System.Text.Json;

namespace Quiz
{
	public class QuizService
	{
		private List<Quiz> quizzes = new List<Quiz>();

		public QuizService()
		{
			if (File.Exists("quizzes.json"))
			{
				string json = File.ReadAllText("quizzes.json");
				quizzes = JsonSerializer.Deserialize<List<Quiz>>(json);
			}
			else
			{
				quizzes = new List<Quiz>();
			}
		}
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

		public void CreateQuiz()
		{
			Console.WriteLine("Введите название новой викторины:");
			string name = Console.ReadLine();

			var questions = new List<Question>();

			while (true)
			{
				Console.WriteLine("Введите текст вопроса (или оставьте пустым, чтобы закончить):");
				string questionText = Console.ReadLine();
				if (string.IsNullOrEmpty(questionText)) break;

				Console.WriteLine("Введите варианты ответов через запятую:");
				var options = Console.ReadLine().Split(',').Select(o => o.Trim()).ToList();

				Console.WriteLine("Введите номера правильных ответов через запятую:");
				var correctAnswers = Console.ReadLine().Split(',').Select(a => int.Parse(a.Trim())).ToList();

				questions.Add(new Question
				{
					Text = questionText,
					Options = options,
					CorrectAnswers = correctAnswers
				});
			}

			var newQuiz = new Quiz
			{
				Name = name,
				Questions = questions
			};

			quizzes.Add(newQuiz);
			SaveQuizzesToFile();
			Console.WriteLine("Викторина успешно добавлена!");
		}

		public void ModifyQuiz()
		{
			Console.WriteLine("Выберите викторину для изменения:");
			for (int i = 0; i < quizzes.Count; i++)
			{
				Console.WriteLine($"{i + 1}. {quizzes[i].Name}");
			}

			int choose = Int32.Parse(Console.ReadLine()) - 1;

			if (choose < quizzes.Count && choose >= 0)
			{
				var selectedQuiz = quizzes[choose];
				Console.WriteLine($"Редактирование викторины: {selectedQuiz.Name}");

				Console.WriteLine("Введите новое название викторины (или оставьте пустым, чтобы не изменять):");
				string newName = Console.ReadLine();
				if (!string.IsNullOrEmpty(newName))
				{
					selectedQuiz.Name = newName;
				}

				Console.WriteLine("Редактировать вопросы? (y/n):");
				if (Console.ReadLine().ToLower() == "y")
				{
					for (int i = 0; i < selectedQuiz.Questions.Count; i++)
					{
						var question = selectedQuiz.Questions[i];
						Console.WriteLine($"Вопрос {i + 1}: {question.Text}");

						Console.WriteLine("Введите новый текст вопроса (или оставьте пустым, чтобы не изменять):");
						string newQuestionText = Console.ReadLine();
						if (!string.IsNullOrEmpty(newQuestionText))
						{
							question.Text = newQuestionText;
						}

						Console.WriteLine("Введите новые варианты ответов через запятую (или оставьте пустым, чтобы не изменять):");
						string newOptions = Console.ReadLine();
						if (!string.IsNullOrEmpty(newOptions))
						{
							question.Options = newOptions.Split(',').Select(o => o.Trim()).ToList();
						}

						Console.WriteLine("Введите номера новых правильных ответов через запятую (или оставьте пустым, чтобы не изменять):");
						string newCorrectAnswers = Console.ReadLine();
						if (!string.IsNullOrEmpty(newCorrectAnswers))
						{
							question.CorrectAnswers = newCorrectAnswers.Split(',').Select(a => int.Parse(a.Trim())).ToList();
						}
					}
				}

				SaveQuizzesToFile();
				Console.WriteLine("Викторина успешно обновлена!");
			}
		}

		private void SaveQuizzesToFile()
		{
			string json = JsonSerializer.Serialize(quizzes, new JsonSerializerOptions { WriteIndented = true });
			File.WriteAllText("quizzes.json", json);
		}
	}
}