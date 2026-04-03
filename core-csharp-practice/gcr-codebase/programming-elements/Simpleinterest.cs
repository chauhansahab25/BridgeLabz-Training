using System;

class Simpleinterest
{
    static void Main()
    {
        Console.Write("Enter principal amount: ");
        int principal = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter rate of interest: ");
        int rate = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter time period (years): ");
        int time = Convert.ToInt32(Console.ReadLine());
        
        int simpleInterest = (principal * rate * time) / 100;
        Console.WriteLine("Simple Interest: " + simpleInterest);
    }
}
