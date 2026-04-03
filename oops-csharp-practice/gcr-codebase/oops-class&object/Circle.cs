using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // Circle class for calculating area and circumference
    class Circle
    {
        public double radius; // radius of circle
        
        // calculate area of circle
        public double getArea()
        {
            return 3.14159 * radius * radius; // pi * r * r
        }
        
        // calculate circumference
        public double getCircumference()
        {
            return 2 * 3.14159 * radius; // 2 * pi * r
        }
        
        // print all circle details
        public void showDetails()
        {
            Console.WriteLine("Radius = " + radius);
            Console.WriteLine("Area = " + getArea());
            Console.WriteLine("Circumference = " + getCircumference());
        }
    }

    class Program
    {
        static void Main()
        {
            Circle c = new Circle(); // create circle object
            c.radius = 7; // set radius value
            
            c.showDetails(); // show results
            
            Console.ReadKey(); // pause screen
        }
    }
}