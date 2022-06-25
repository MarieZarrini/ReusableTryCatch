namespace ReusableTryCatch
{
	class Program
	{
		static void Main(string[] args)
		{
			SafeExecutor(AuthenticateUser);
		}


		static readonly Action AuthenticateUser = () =>
		{
			var user = new User() { Name = "Marie" };
			var authenticationService = new AuthenticationService();

			authenticationService.Authenticated += MailService.OnAuthenticated;
			authenticationService.Authenticated += MessageService.OnAuthenticated;

			authenticationService.Authenticate(user);
		};

		private static void SafeExecutor(Action action)
		{
			try
			{
				action();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			finally
			{
				Console.WriteLine("All Done :)");
			}
		}
	}
}