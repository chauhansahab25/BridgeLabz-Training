using System;

class NumberOfPossibleHandshakes
{
	static void Main()
	{
		Console.WriteLine("Enter Number of Students : ");
		int numberOfStudents = Convert.ToInt32(Console.ReadLine());
		int numberOfHandshakes = (numberOfStudents * (numberOfStudents - 1))/2;

		Console.WriteLine("Maximum number of possible handshakes among "+numberOfStudents+" students are "+ numberOfHandshakes);
	}

}