using System;

class UnitPrice
{
	static void Main()
	{
		Console.WriteLine("Enter unit price of an item :");
		int unitPrice = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter the quantity to be bought :");
		int quantity = Convert.ToInt32(Console.ReadLine());
		int totalPrice = unitPrice * quantity;

		Console.WriteLine("The total price is INR "+ totalPrice+" if the quantity "+ quantity +" and unit price is INR "+ unitPrice );		
	}
}