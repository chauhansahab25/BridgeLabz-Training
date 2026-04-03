using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.NewFolder
{
    public class Trigonometry
{

   //main method
    static void Main(string[] args)
    {

        Console.Write("Enter angle in degrees: ");
        double angle = Convert.ToDouble(Console.ReadLine());

        double[] ans = TrigonometricFunctions(angle);



       
        Console.WriteLine("Sine: " + ans[0]);

        Console.WriteLine("Cosine: " + ans[1]);
        
        Console.WriteLine("Tangent: " + ans[2]);
    }


    static double[] TrigonometricFunctions(double a)
    {

        //convert angle into radians
        double radians = a * Math.PI / 180; 

        double sine = Math.Sin(radians);


        double cosine = Math.Cos(radians);


        double tangent = Math.Tan(radians);

        return new double[] { sine, cosine, tangent };


    }
}