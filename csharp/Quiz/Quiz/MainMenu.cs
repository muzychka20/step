namespace Quiz
{
	public class MainMenu
	{
		private UserRepository userRepository;

		public MainMenu(UserRepository _userRepository)
		{
			userRepository = _userRepository;
		}

		public void Show()
		{
			while (true)
			{
				Console.WriteLine("1. Login");
				Console.WriteLine("2. Register");
				Console.WriteLine("3. Exit");
				int choose = int.Parse(Console.ReadLine());
				if (choose == 3)
				{
					break;
				}
				switch (choose)
				{
					case 1:
						userRepository.AuthUser();
						if (UserStore.authUserId != null)
						{
							UserMenu menu = new UserMenu(userRepository);
							menu.Show();
						}
						break;
					case 2:
						userRepository.RegisterUser();
						break;
				}
				Console.ReadLine();
			}
		}
	}
}