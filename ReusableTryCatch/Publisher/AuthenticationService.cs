namespace ReusableTryCatch
{
	internal class AuthenticationService
	{
		public event EventHandler<AuthenticationEventArgs>? Authenticated;

		public void Authenticate(User user)
		{
			Console.WriteLine("Authenticating user...");

			OnAuthenticated(user);
		}


		private void OnAuthenticated(User user)
		{
			if (Authenticated != null)
				Authenticated(this, new AuthenticationEventArgs() { User = user });
		}
	}


	internal class AuthenticationEventArgs : EventArgs
	{
		public User User { get; set; }
	}
}