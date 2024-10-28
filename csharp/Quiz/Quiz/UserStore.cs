namespace Quiz
{
	public static class UserStore
	{
		public static List<UserModel> users = new List<UserModel>()
		{
			new UserModel
			{
				Id = "admin",
				Login = "admin",
				Password = "admin",
			}
		};
		public static string authUserId = null;
		public static UserModel GetCurrentUser()
		{
			return users.FirstOrDefault(u => u.Id == authUserId);
		}
	}
}