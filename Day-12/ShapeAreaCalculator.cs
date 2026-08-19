using System;
using System.Collections.Generic;
abstract class Shape
{
    public abstract double CalculateArea();
}
class Circle : Shape
{
    private double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
}
class Rectangle : Shape
{
    private double length;
    private double width;
    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }
    public override double CalculateArea()
    {
        return length * width;
    }
}
class Triangle : Shape
{
    private double baseValue;
    private double height;
    public Triangle(double baseValue, double height)
    {
        this.baseValue = baseValue;
        this.height = height;
    }
    public override double CalculateArea()
    {
        return 0.5 * baseValue * height;
    }
}
class Program
{
    static void Main()
    {
        Console.Write("Enter number of shapes: ");
        int n = Convert.ToInt32(Console.ReadLine());

        List<Shape> shapes = new List<Shape>();
        for (int i = 0; i < n; i++)
        {
            Console.Write("\nEnter shape (Circle/Rectangle/Triangle): ");
            string type = Console.ReadLine();
            if (type.ToLower() == "circle")
            {
                Console.Write("Enter radius: ");
                double radius = Convert.ToDouble(Console.ReadLine());
                shapes.Add(new Circle(radius));
            }
            else if (type.ToLower() == "rectangle")
            {
                Console.Write("Enter length: ");
                double length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter width: ");
                double width = Convert.ToDouble(Console.ReadLine());
                shapes.Add(new Rectangle(length, width));
            }
            else if (type.ToLower() == "triangle")
            {
                Console.Write("Enter base: ");
                double baseValue = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter height: ");
                double height = Convert.ToDouble(Console.ReadLine());

                shapes.Add(new Triangle(baseValue, height));
            }
            else
            {
                Console.WriteLine("Invalid shape");
            }
        }
        Console.WriteLine("\nAreas:");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.CalculateArea().ToString("F2"));
        }
    }
}