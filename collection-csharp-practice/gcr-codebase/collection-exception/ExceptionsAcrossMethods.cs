using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFour.Exception
{
    public class ExceptionsAcrossMethods
    {
        static void Method1()
        {
            int result = 10 / 0; // Throws ArithmeticException
        }

        static void Method2()
        {
            Method1(); 
        }

        public static void Main(string[] args)
        {
            try
            {
                Method2();
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Handled exception in Main");
            }
        }
    }
}
