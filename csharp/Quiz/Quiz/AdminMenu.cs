namespace Quiz
{
	public class AdminMenu
	{
		private QuizService quizService = new QuizService();

		public void Show()
		{
			while (true)
			{
				Console.WriteLine("1. Create Quiz");
				Console.WriteLine("2. Modify Quiz");
				Console.WriteLine("3. Exit");

				int choose = int.Parse(Console.ReadLine());
				if (choose == 3)
				{
					UserStore.authUserId = null;
					break;
				}

				switch (choose)
				{
					case 1:
						quizService.CreateQuiz();
						break;

					case 2:
						quizService.ModifyQuiz();
						break;
				}

				Console.WriteLine();
			}
		}
	}
}