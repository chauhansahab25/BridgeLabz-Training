using System;

public class QuotientRemainder {
    public static void Main(String[] args){
	

	Console.WriteLine("Enter the Divident : ");
	String input1 = Console.ReadLine();


	Console.WriteLine("Enter the Divisor : ");
	String input2 = Console.ReadLine();


	int number = int.Parse(input1);
	int divisor = int.Parse(input2);

	Console.WriteLine("Quotient = " + (number / divisor)  + " and Remainder = " + (number % divisor));	


}




}