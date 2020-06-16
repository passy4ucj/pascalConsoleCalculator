using System;

namespace PascalCalculator
{
	class Program
	{
		static void Main(string[] args)
		{
			double num1 = 0;
			double num2 = 0;

			Console.ForegroundColor = ConsoleColor.Blue;

			Console.WriteLine("Pascal's Calculator in C#\r", Console.ForegroundColor);
			Console.WriteLine("........................\n");

			Console.WriteLine("Enter a number and press enter");
			num1 = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Enter another number and press enter");
			num2 = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Choose an option from the following");
			Console.WriteLine("\ta  -  Add");
			Console.WriteLine("\ts  -  Subtract");
			Console.WriteLine("\tm  -  Multiply");
			Console.WriteLine("\td  -  Divide");
			Console.WriteLine("Your Option?");

			switch (Console.ReadLine())
			{
				case "a":
					Console.WriteLine($"Your result {num1} + {num2}  = " + (num1+num2));
					break;
				case "s":
					Console.WriteLine($"Your result {num1} - {num2}  = " + (num1 - num2));
					break;
				case "m":
					Console.WriteLine($"Your result {num1} * {num2}  = " + (num1 * num2));
					break;
				case "d":
					while (num2 == 0)
					{
						Console.WriteLine("Enter a non zero number !!!");
						num2 = Convert.ToDouble(Console.ReadLine());
					}
					Console.WriteLine($"Your result {num1} / {num2}  = " + (num1 / num2));
					break;
				
			}

			Console.WriteLine("Press any key to close the console");


			Console.ReadKey();
		}
	}
}
