using System;
class EmployeeBonus
{
	static void Main(String[] args)
	{
		Console.Write("Enter employee salary");
		
		int salary = Convert.ToInt32(Console.ReadLine());//taking input
        Console.Write("Enter years of service");
		int yearsOfService = Convert.ToInt32(Console.ReadLine());
		int bonus =0;
		if(yearsOfService > 5){
			bonus = salary * 0.05;
		}
		Console.WriteLine("The bonus amount is :" + bonus);
	}
}	