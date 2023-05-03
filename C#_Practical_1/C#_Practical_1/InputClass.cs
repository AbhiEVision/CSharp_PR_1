using System.Text.RegularExpressions;

namespace Calculator
{
	public static class InputClass
	{
		public static Numbers TakeNumbersFromUser()
		{
			int firstNUmber = 0, secondNumber = 0;
			bool numberGot = false;

			// First number input
			while (!numberGot)
			{
				UIClass.PrintLine("Enter the First number : ");
				string temp = Console.ReadLine();
				Regex x = new(
					@"^([+-]?\d*|0)$");
				if (x.IsMatch(temp) && temp != "")
				{
					try
					{
						firstNUmber = Convert.ToInt32(temp);
						numberGot = true;
					}
					catch
					{
						UIClass.PrintError($"Please enter values between {int.MinValue} and {int.MaxValue}");
					}
				}
				else
				{
					UIClass.PrintError("Please enter valid integer number");
				}
			}

			UIClass.PrintLine("");
			numberGot = false;

			// Second Number Input
			while (!numberGot)
			{
				UIClass.PrintLine("Enter the Second number : ");
				string temp = Console.ReadLine();
				Regex x = new(
					@"^([+-]?\d*|0)$");
				if (x.IsMatch(temp))
				{
					try
					{
						secondNumber = Convert.ToInt32(temp);
						if (secondNumber == 0)
						{
							UIClass.PrintError("Can't enter 0 as a Second number");
						}
						else
						{
							numberGot = true;
						}
					}
					catch
					{
						UIClass.PrintError($"Please enter values between {int.MinValue} and {int.MaxValue}");
					}
				}
				else
				{
					UIClass.PrintError("Please enter valid integer number");
				}
			}

			return new Numbers(firstNUmber, secondNumber);
		}
	}
}
