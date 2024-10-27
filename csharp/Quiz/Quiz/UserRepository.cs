using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
	public class UserRepository
	{
		public void RegisterUser()
		{
			Console.WriteLine("Login: "); string login = Console.ReadLine();
			Console.WriteLine("Password: "); string password = Console.ReadLine();
			Console.WriteLine("Birthday: "); string birthday = Console.ReadLine();
			UserModel newUser = new UserModel
			{
				Login = login,
				Password = password,
				Birthday = DateTime.Parse(birthday),
				Id = Guid.NewGuid().ToString()
			};
			if (CheckParamNewUser(newUser))
			{
				UserStore.users.Add(newUser);
				Console.WriteLine("You registered!");
			}
			else
			{
				Console.WriteLine("Error! Inavalid parameters! Enter another login!");
			}
		}

		public void AuthUser()
		{
			Console.WriteLine("Login: "); string login = Console.ReadLine();
			Console.WriteLine("Password: "); string password = Console.ReadLine();
			UserModel user = new UserModel
			{
				Login = login,
				Password = password,
			};
			UserModel um = CheckAuth(user);
			if (um != null)
			{
				UserStore.authUserId = um.Id;
				Console.WriteLine("Loged in successfully!");
			}
			else
			{
				Console.WriteLine("Incorrect data!");
			}
		}

		public void ChangeParams(string userId)
		{
			Console.WriteLine("New password: "); string newPass = Console.ReadLine();
			Console.WriteLine("New birthdate: "); string newDate = Console.ReadLine();
			for (int i = 0; i < UserStore.users.Count; i++)
			{
				if (UserStore.users[i].Id == userId)
				{
					UserStore.users[i].Password = newPass;
					UserStore.users[i].Birthday = DateTime.Parse(newDate);
				}
			}
		}

		public List<UserModel> GetTop20()
		{
			return UserStore.users.OrderBy(u => u.Points).Take(20).ToList();
		}

		public void ShowResults()
		{
			UserModel user = UserStore.users.Where(u => u.Id == UserStore.authUserId).First();
			foreach (var qr in user.QuizResults)
			{
				qr.ToString();
			}
		}

		private UserModel CheckAuth(UserModel user)
		{
			foreach (var u in UserStore.users)
			{
				if (u.Login == user.Login && u.Password == user.Password)
				{
					return u;
				}
			}
			return null;
		}

		private bool CheckParamNewUser(UserModel user)
		{
			foreach (var u in UserStore.users)
			{
				if (u.Login == user.Login)
				{
					return false;
				}
			}
			return true;
		}
	}
}
