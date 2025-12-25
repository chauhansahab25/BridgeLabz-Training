using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.NewFolder
{
    public class SimpleInterest
    {
        public static void Main(string[] args)
        {

            //input principle value
            Console.WriteLine("Enter Principle");
            double p = Convert.ToDouble(Console.ReadLine());

            //input rate value
            Console.WriteLine("Enter Rate");
            double r = Convert.ToDouble(Console.ReadLine());

            //input time
            Console.WriteLine("Enter Time");
            double t = Convert.ToDouble(Console.ReadLine());


            //calculate simple interest
            double simpleInterest = CalculateSimpleInterest(p, r, t);

            Console.WriteLine($"Simple Interst is : {simpleInterest}");

        }

        static double CalculateSimpleInterest(double p, double r, double t)
        {
            return (p * r * t) / 100;

        }
    }
}
