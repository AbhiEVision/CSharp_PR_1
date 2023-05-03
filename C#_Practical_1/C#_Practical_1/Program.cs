namespace Calculator
{
	internal class Program
	{
		// Entry point of project
		static void Main(string[] args)
		{
			Numbers userInput = InputClass.TakeNumbersFromUser();
			UIClass.PrintResult(CalculateDataFromGivenData(userInput), userInput);
		}

		// Calculating addition, multiplication etc...
		public static CalculatorResultData CalculateDataFromGivenData(Numbers numbers)
		{
			double x = numbers.number1;
			double y = numbers.number2;

			return new CalculatorResultData(x + y, x - y, x * y, Math.Round(x / y, 4));
		}
	}
}