//using System;

//class FizzBuzzProgram
//{
//	static void Main()
//	{
//		Console.Write("Enter a positive integer: ");
//		string userInput = Console.ReadLine();

//		int number;
//		bool isValidNumber = int.TryParse(userInput, out number);

//		if (!isValidNumber || number <= 0)
//		{
//			Console.WriteLine("You must enter a positive number.");
//			return;
//		}

//		string[] results = new string[number + 1];

//		for (int i = 1; i <= number; i++)
//		{
//			if (i % 3 == 0 && i % 5 == 0)
//				results[i] = "FizzBuzz";
//			else if (i % 3 == 0)
//				results[i] = "Fizz";
//			else if (i % 5 == 0)
//				results[i] = "Buzz";
//			else
//				results[i] = i.ToString();
//		}

//		for (int i = 1; i <= number; i++)
//		{
//			Console.WriteLine("Position " + i + " = " + results[i]);
//		}
//	}
//}
