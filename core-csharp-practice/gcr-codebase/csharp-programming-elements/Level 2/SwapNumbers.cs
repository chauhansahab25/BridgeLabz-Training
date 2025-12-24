using System;
class SwapNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter number1: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter number2: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Swapping using a temporary variable
        double temp = num1;
        num1 = num2;
        num2 = temp;

        Console.WriteLine("The swapped numbers are " + num1 + " and " + num2);
    }
}
