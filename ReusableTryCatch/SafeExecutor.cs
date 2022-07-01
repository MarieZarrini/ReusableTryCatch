namespace ReusableTryCatch
{
	internal class SafeExecutor
	{
		public static void TryExecutingAction(Action action)
		{
			try
			{
				action();
			}
			catch (NullReferenceException)
			{
				Console.WriteLine("Null Reference Exception.");
			}
			catch (ArgumentException)
			{
				Console.WriteLine("Argument Exception.");
			}
			catch (Exception)
			{
				Console.WriteLine("Something bad happens.");
			}
			finally
			{
				Console.WriteLine("All Done.");
			}
		}
	}
}
