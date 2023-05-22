namespace DebuggingApplication
{
	internal class Program
	{
		
		static void Main(string[] args)
		{
			string userResponse = Console.ReadLine();

			if (Convert.ToBoolean(int.Parse(userResponse)))
			{

				Console.WriteLine("The entered value is a integer");

			}
		}
	}
}