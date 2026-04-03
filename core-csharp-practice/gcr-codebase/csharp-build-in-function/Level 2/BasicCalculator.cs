using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.Build_In_Function
{
    public class BasicCalculator
    {
        static double Add(double a, double b) => a + b;
        static double Subtract(double a, double b) => a - b;
        static double Multiply(double a, double b) => a * b;
        static double Divide(double a, double b) => a / b;

        static void Main()
        {
            Console.Write("Enter two numbers: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Choose operation (+ - * /): ");
            char op = Console.ReadLine()[0];

            if (op == '+') Console.WriteLine(Add(a, b));
            else if (op == '-') Console.WriteLine(Subtract(a, b));
            else if (op == '*') Console.WriteLine(Multiply(a, b));
            else if (op == '/') Console.WriteLine(Divide(a, b));
        }
    }
}
