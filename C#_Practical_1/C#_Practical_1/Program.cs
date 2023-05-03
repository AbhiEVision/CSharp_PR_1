using System.Runtime.InteropServices;

namespace Calculator
{
	internal class Program
	{
		#region Function Form outside
		// Getting the functions form outside a program
		[DllImport("kernel32.dll", ExactSpelling = true)]
		private static extern IntPtr GetConsoleWindow();
		private static IntPtr ThisConsole = GetConsoleWindow();

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
		private const int MAXIMIZE = 3;

		#endregion


		// maximizing the console
		static Program()
		{
			Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
			ShowWindow(ThisConsole, MAXIMIZE);
		}

		static void Main(string[] args)
		{
			Numbers userInput = InputClass.TakeNumbersFromUser();
			UIClass.PrintResult(CalculateDataFromGivenData(userInput), userInput);

			//int a = 10, b = 0;
   //         Console.WriteLine(a/b);
        }

		public static CalculatorResultData CalculateDataFromGivenData(Numbers numbers)
		{
			double x = numbers.number1;
			double y = numbers.number2;

			return new CalculatorResultData(x+y,x-y,x*y,Math.Round((x/y),4));
		}
	}
}