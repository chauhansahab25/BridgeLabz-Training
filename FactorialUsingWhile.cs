using System;
class FactorialUsingWhile
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        if (number <= 0){// Check for positive integer
            Console.WriteLine("Please enter a positive integer");
            return;
        }
        long factorial = 1;
        int i = 1;
        while (i <= number){
            factorial = factorial * i;
            i++;
        }
        Console.WriteLine("The factorial of " + number + " is " + factorial);
    }
}
