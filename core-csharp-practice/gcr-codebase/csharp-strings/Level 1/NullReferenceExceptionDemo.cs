using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.Strings
{
    public class NullReferenceExceptionDemo
    {
        public static void DemonstrateNullReference()
        {
            string message = null;

            // This line will throw NullReferenceException
            Console.WriteLine("Length of string: " + message.Length);
        }

        static void Main(string[] args)
        {
            try
            {
                DemonstrateNullReference();
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Exception Caught: NullReferenceException");
                Console.WriteLine("Message: " + ex.Message);
            }

            Console.WriteLine("\nProgram execution continues safely.");
        }
    }
}
