namespace Quiz
{
	public static class UserStore
	{
		public static List<UserModel> users = new List<UserModel>();
		public static string authUserId = null;
		public static UserModel GetCurrentUser()
		{
			return users.FirstOrDefault(u => u.Id == authUserId);
		}
	}
}