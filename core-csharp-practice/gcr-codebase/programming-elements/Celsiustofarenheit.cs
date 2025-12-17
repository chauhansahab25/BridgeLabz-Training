using System;

class Celsiustofarenheit
{
    static void Main()
    {
        Console.Write("Enter temperature in Celsius: ");
        int celsius = Convert.ToInt32(Console.ReadLine());

        int fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
    }
}
