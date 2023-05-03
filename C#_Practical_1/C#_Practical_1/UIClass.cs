namespace Calculator
{
	public static class UIClass
	{

		// Print the Result in Perticular format
		public static void PrintResult(CalculatorResultData dataToPrint, Numbers numbers)
		{
			int maxLengthOfResult = dataToPrint.multiplicatioResult.ToString().Length > dataToPrint.divisionResult.ToString().Length ?
				dataToPrint.multiplicatioResult.ToString().Length :
				dataToPrint.divisionResult.ToString().Length;

			if (maxLengthOfResult < dataToPrint.additionResult.ToString().Length)
			{
				maxLengthOfResult = dataToPrint.additionResult.ToString().Length;
			}
			if (maxLengthOfResult < dataToPrint.substractionResult.ToString().Length)
			{
				maxLengthOfResult = dataToPrint.substractionResult.ToString().Length;
			}

			// *[space]Number1[space]+[space]number2[space]=[space]resultmaxLength[space]*
			int totalLength = 2 + numbers.number1.ToString().Length + 3 + numbers.number2.ToString().Length + 3 +
							  maxLengthOfResult + 2;

			int spaceOnEachSide = (totalLength - 8) / 2;
			int commonSize = 2 + numbers.number1.ToString().Length + 3 + numbers.number2.ToString().Length + 3;

			int length = 9 + numbers.number1.ToString().Length + numbers.number2.ToString().Length + dataToPrint.additionResult.ToString().Length;

			Console.ForegroundColor = ConsoleColor.Green;

			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();

			Console.Write("\t");
			// all upeer side *'s
			for (int i = 0; i < totalLength; i++)
			{
				Console.Write("*");
			}

			Console.WriteLine();

			Console.Write("\t*");

			for (int i = 0; i < totalLength - 2; i++)
			{
				Console.Write(" ");
			}

			Console.WriteLine("*");


			Console.Write("\t*");

			// printing space 
			for (int i = 0; i < spaceOnEachSide; i++)
			{
				Console.Write(" ");
			}

			// printing Result 
			Console.Write("Result");

			// space on other side 
			if (totalLength == (spaceOnEachSide * 2) + 8)
			{
				for (int i = 0; i < spaceOnEachSide; i++)
				{
					Console.Write(" ");
				}
			}
			else
			{
				for (int i = 0; i < spaceOnEachSide + 1; i++)
				{
					Console.Write(" ");
				}
			}

			// printing ending *
			Console.Write("*");

			Console.WriteLine();

			Console.Write("\t*");

			for (int i = 0; i < totalLength - 2; i++)
			{
				Console.Write(" ");
			}

			Console.WriteLine("*");

			Console.Write("\t");

			// print all * below result 
			for (int i = 0; i < totalLength; i++)
			{
				Console.Write("*");
			}

			Console.WriteLine();

			// next line
			Console.Write("\t*");

			for (int i = 0; i < totalLength - 2; i++)
			{
				Console.Write(" ");
			}

			Console.WriteLine("*");


			// writing the addition
			Console.Write($"\t* {numbers.number1} + {numbers.number2} = {dataToPrint.additionResult}");


			for (int i = 0; i < totalLength - length; i++)
			{
				Console.Write(" ");
			}

			Console.WriteLine("*");

			Console.Write("\t*");

			for (int i = 0; i < totalLength - 2; i++)
			{
				Console.Write(" ");
			}

			Console.WriteLine("*");

			// Printining the substraction
			Console.Write($"\t* {numbers.number1} - {numbers.number2} = {dataToPrint.substractionResult}");

			length = 9 + numbers.number1.ToString().Length + numbers.number2.ToString().Length + dataToPrint.substractionResult.ToString().Length;

			for (int i = 0; i < totalLength - length; i++)
			{
				Console.Write(" ");
			}

			Console.WriteLine("*");

			Console.Write("\t*");

			for (int i = 0; i < totalLength - 2; i++)
			{
				Console.Write(" ");
			}

			Console.WriteLine("*");

			// Printing the multiplication
			Console.Write($"\t* {numbers.number1} * {numbers.number2} = {dataToPrint.multiplicatioResult}");

			length = 9 + numbers.number1.ToString().Length + numbers.number2.ToString().Length + dataToPrint.multiplicatioResult.ToString().Length;

			for (int i = 0; i < totalLength - length; i++)
			{
				Console.Write(" ");
			}

			Console.WriteLine("*");

			Console.Write("\t*");

			for (int i = 0; i < totalLength - 2; i++)
			{
				Console.Write(" ");
			}

			Console.WriteLine("*");

			// Printing last the division
			Console.Write($"\t* {numbers.number1} / {numbers.number2} = {dataToPrint.divisionResult}");

			length = 9 + numbers.number1.ToString().Length + numbers.number2.ToString().Length + dataToPrint.divisionResult.ToString().Length;

			for (int i = 0; i < totalLength - length; i++)
			{
				Console.Write(" ");
			}

			Console.WriteLine("*");

			Console.Write("\t*");

			for (int i = 0; i < totalLength - 2; i++)
			{
				Console.Write(" ");
			}

			Console.WriteLine("*");

			Console.Write("\t");
			// compplete the lower side
			for (int i = 0; i < totalLength; i++)
			{
				Console.Write("*");
			}

			Console.WriteLine();

			Console.ForegroundColor = ConsoleColor.White;
		}

		public static void PrintError(string ErrorMessage)
		{
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(ErrorMessage);
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine();
		}

		public static void PrintLine(string stringToPrint)
		{
			Console.WriteLine(stringToPrint);
		}
	}
}