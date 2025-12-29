using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.String.Built_in.Problem_Statement
{
    public class TemperatureConverter
    {
        static double CelsiusToFahrenheit(double c)
        {
            return (c * 9 / 5) + 32;
        }

        static double FahrenheitToCelsius(double f)
        {
            return (f - 32) * 5 / 9;
        }

        static void Main()
        {
            Console.Write("Enter temperature: ");
            double temp = Convert.ToDouble(Console.ReadLine());

            Console.Write("Convert to (C/F): ");
            char choice = Console.ReadLine()[0];

            if (choice == 'C')
                Console.WriteLine("Celsius: " + FahrenheitToCelsius(temp));
            else
                Console.WriteLine("Fahrenheit: " + CelsiusToFahrenheit(temp));
        }
    }
}
