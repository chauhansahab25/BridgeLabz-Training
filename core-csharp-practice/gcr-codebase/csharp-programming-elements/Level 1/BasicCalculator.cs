using System;

class BasicCalculator
{
    static void Main()
    {
        double num1;
        double num2;
        
        Console.Write("Enter first no: ");
        num1 = Convert.ToDouble(Console.ReadLine());
        
        
        Console.Write("Enter second no: ");
        num2 = Convert.ToDouble(Console.ReadLine());
        

        double add = num1 + num2;
        double sub = num1 - num2;
        double mul = num1 * num2;
        double div = num1 / num2;
        
        Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers " 
                          + num1 + " and " + num2 + " is " 
                          + add + ", " + sub + ", " 
                          + mul + ", and " + div);
    }
}
