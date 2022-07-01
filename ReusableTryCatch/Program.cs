namespace ReusableTryCatch
{
	class Program
	{
		static void Main(string[] args)
		{
			AuthenticateUser();
		}


		private static void AuthenticateUser()
		{
			SafeExecutor.TryExecutingAction(() =>
			{
				var user = new User() { Name = "Marie" };
				var authenticationService = new AuthenticationService();

				authenticationService.Authenticated += MailService.OnAuthenticated;
				authenticationService.Authenticated += MessageService.OnAuthenticated;

				authenticationService.Authenticate(user);
			});
		}
	}
}