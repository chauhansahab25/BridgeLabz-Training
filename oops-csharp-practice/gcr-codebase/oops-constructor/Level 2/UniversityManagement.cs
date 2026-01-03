using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // student class for university
    class Student
    {
        public int rollNumber;      // anyone can access
        protected string name;      // only this class and child classes
        private double CGPA;        // only this class

        public Student(int roll, string n, double cgpa)
        {
            rollNumber = roll;
            name = n;
            CGPA = cgpa;
        }

        // get cgpa value
        public double getCGPA()
        {
            return CGPA;
        }

        // set new cgpa
        public void setCGPA(double newCGPA)
        {
            CGPA = newCGPA;
            Console.WriteLine("CGPA changed to: " + CGPA);
        }

        public void displayInfo()
        {
            Console.WriteLine("Roll: " + rollNumber);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("CGPA: " + CGPA);
        }
    }

    // pg student inherits from student
    class PostgraduateStudent : Student
    {
        public string researchArea;

        public PostgraduateStudent(int roll, string n, double cgpa, string research) 
            : base(roll, n, cgpa)
        {
            researchArea = research;
        }

        public void showDetails()
        {
            Console.WriteLine("PG Student:");
            Console.WriteLine("Roll: " + rollNumber);        // can access public
            Console.WriteLine("Name: " + name);              // can access protected
            Console.WriteLine("CGPA: " + getCGPA());         // cant access private directly
            Console.WriteLine("Research: " + researchArea);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            Student s1 = new Student(101, "John", 8.5);
            s1.displayInfo();
            Console.WriteLine();

            s1.setCGPA(9.0);
            Console.WriteLine();

            PostgraduateStudent pg1 = new PostgraduateStudent(201, "Alice", 9.2, "AI");
            pg1.showDetails();

            Console.ReadLine();
        }
    }
}