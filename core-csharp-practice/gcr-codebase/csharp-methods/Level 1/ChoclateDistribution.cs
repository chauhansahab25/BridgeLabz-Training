using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.NewFolder
{
    public class ChoclateDistribution
    {

        public static void Main(string[] args)
        {

            //input choclate
            Console.WriteLine("Enter No of Choclate");

            int numberOfChoclate=Convert.ToInt32(Console.ReadLine());


            // input no. of childerm
            Console.WriteLine("Enter No of Childern");

                int numberOfChildren=Convert.ToInt32(Console.ReadLine());   

            int[] result = calculation(numberOfChoclate, numberOfChildren);

            Console.WriteLine("Each child will get " + result[0] + " chocolates");
            Console.WriteLine("Remaining chocolates = " + result[1]);




        }

        public static int[] calculation(int number, int divisor)
        {
            // Chocolates per child
            int q = number / divisor;

            // Remaining chocolates
            int r = number % divisor;  

            return new int[] { q, r };
        }
    }
}
