using System;

public class FarenheitToCelsius
{
    static void Main(string[] args)
    {
        Console.Write("Enter temperature in Fahrenheit: ");

        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        double celsius = (fahrenheit - 32) * 5 / 9;


        Console.WriteLine("The " + fahrenheit + " Fahrenheit is " + celsius + " Celsius");
    }
}
