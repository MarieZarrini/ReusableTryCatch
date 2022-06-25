namespace ReusableTryCatch
{
	internal class MessageService
	{
		public static void OnAuthenticated(object source, AuthenticationEventArgs args)
		{
			Console.WriteLine($"MessageService: Sending a message to {args.User.Name}...");
		}
	}
}