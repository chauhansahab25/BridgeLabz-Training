using System;
class PoundsToKilograms
{
    static void Main(string[] args)
    {
        Console.Write("Enter weight in pounds: ");
        double pound = Convert.ToDouble(Console.ReadLine());


        // 1 pound = 2.2 kg
        double kilograms = pound / 2.2;
        Console.WriteLine("The weight of the person in pounds is " + pound +" and in kg is " + kilograms);
    }
}
