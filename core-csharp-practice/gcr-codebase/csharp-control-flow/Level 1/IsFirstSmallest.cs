using System;
class IsFirstSmallest{
	static void Main(String []args){
		Console.WriteLine("Enter three number"); 
		int num1=int.Parse(Console.ReadLine());
		int num2=int.Parse(Console.ReadLine());
		int num3=int.Parse(Console.ReadLine());
		if(num1<num2&&num1<num3)
		{
		Console.WriteLine(" Is the first number the smallest? Yes");}
		else
		{			
	Console.WriteLine(" Is the first number the smallest? No");
		}
		
		
	}
}