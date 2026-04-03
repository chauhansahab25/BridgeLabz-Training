using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // Circle class with constructor chaining
    class Circle
    {
        public double radius;

        // default constructor - calls parameterized constructor
        public Circle() : this(1.0)  // constructor chaining
        {
            Console.WriteLine("Default constructor called");
        }

        // parameterized constructor
        public Circle(double r)
        {
            radius = r;
            Console.WriteLine("Parameterized constructor called");
        }

        // calculate area
        public double getArea()
        {
            return 3.14159 * radius * radius;
        }

        // show circle details
        public void displayCircle()
        {
            Console.WriteLine("Radius: " + radius);
            Console.WriteLine("Area: " + getArea());
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            // using default constructor (will chain to parameterized)
            Console.WriteLine("Creating circle with default constructor:");
            Circle c1 = new Circle();
            c1.displayCircle();

            // using parameterized constructor directly
            Console.WriteLine("Creating circle with parameterized constructor:");
            Circle c2 = new Circle(5.0);
            c2.displayCircle();

            Console.ReadKey();
        }
    }
}