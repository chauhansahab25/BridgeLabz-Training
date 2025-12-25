using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.NewFolder
{
    public class TemperatureOfWind
    {
        
        public static void Main(string[] args)
        {
            //input temperature
            Console.Write("Enter temperature in Fahrenheit: ");
            double temperature = Convert.ToDouble(Console.ReadLine());

            //input speed
            Console.Write("Enter wind speed in mph: ");
            double windSpeed = Convert.ToDouble(Console.ReadLine());

            double WindTemp = CalculateWindChill(temperature, windSpeed);

            Console.WriteLine("Wind Chill Temperature: " + WindTemp);
        }

        public static double CalculateWindChill(double temp, double windSpeed)
        {
            double windChill = 35.74  + 0.6215 * temp+ (0.4275 * temp - 35.75) * Math.Pow(windSpeed, 0.16);

            return windChill;

        }
    }

}