using System;
class Multiplicationtable
{
	static void Main(String[] args)
	{
		Console.Write("Enter the number");//taking input
		
		int number = Convert.ToInt32(Console.ReadLine());
		for(int i=6; i<=9;i++){
			Console.WriteLine(number + " * " + i + " = " +(number * i));
		}
	}
	
}