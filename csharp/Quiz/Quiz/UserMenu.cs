namespace Quiz
{
	public class UserMenu
	{
		private UserRepository userRepository;
		private QuizService quizService = new QuizService();

		public UserMenu(UserRepository _userRepository)
		{
			userRepository = _userRepository;
		}

		public void Show()
		{
			while (true)
			{
				Console.WriteLine("1. Start Quiz");
				Console.WriteLine("2. Show results");
				Console.WriteLine("3. Show top 20");
				Console.WriteLine("4. Settings");
				Console.WriteLine("5. Exit");

				int choose = int.Parse(Console.ReadLine());
				if (choose == 5)
				{
					break;
				}

				switch (choose)
				{
					case 1:
						quizService.TakeQuiz();
						break;

					case 2:
						userRepository.ShowResults();
						break;

					case 3:
						{
							foreach (var el in userRepository.GetTop20())
							{
								el.ToString();
							}
							Console.WriteLine("--------------------------");
							break;
						}

					case 4:
						userRepository.ChangeParams(UserStore.authUserId);
						break;
				}

				Console.WriteLine();
			}
		}
	}
}