using System;

public class CelsiusToFarenheit
{
    static void Main(string[] args)
    {
        Console.Write("Enter temperature in Celsius: ");

        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine("The " + celsius + " Celsius is " + fahrenheit + " Fahrenheit");
    }
}
