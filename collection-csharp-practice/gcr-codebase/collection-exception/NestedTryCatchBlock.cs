using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFour.Exception
{
    public class NestedTryCatchBlock
    {
        //Using Nested try-catch Blocks
        public static void Main(string[] args)
        {
            int[] arr = { 50, 60, 70, 80 };

            try
            {
                Console.Write("Enter index: ");
                int index = Convert.ToInt32(Console.ReadLine());


                try
                {
                    Console.Write("Enter divisor: ");
                    int divisor = Convert.ToInt32(Console.ReadLine());

                    int result = arr[index] / divisor;
                    Console.WriteLine("Result: " + result);
                }


                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero!");
                }


            }


            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid array index!");
            }
        }
    }
}
