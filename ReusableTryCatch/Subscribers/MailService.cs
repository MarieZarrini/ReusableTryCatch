namespace ReusableTryCatch
{
	internal class MailService
	{
		public static void OnAuthenticated(object source, AuthenticationEventArgs args)
		{
			Console.WriteLine($"MailService: Sending an email to {args.User.Name}...");
		}
	}
}
