using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFour.Exception
{
    public class finallyBlockExecution
    {
        //Write a program that performs integer division and demonstrates the finally block execution.

        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter first number: ");
                int n1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                int n2 = Convert.ToInt32(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine("Result: " + result);
            }



            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }



            finally
            {
                Console.WriteLine("Operation completed");
            }
        }
    }
}
