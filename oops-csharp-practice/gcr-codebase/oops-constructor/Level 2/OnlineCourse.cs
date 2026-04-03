using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // Online course management system
    class Course
    {
        // instance variables - different for each course
        public string courseName;
        public int duration; // in months
        public double fee;
        
        // class variable - same institute name for all courses
        public static string instituteName = "TechEdu Institute";

        // constructor
        public Course(string name, int dur, double f)
        {
            courseName = name;
            duration = dur;
            fee = f;
        }

        // instance method - display details of this course
        public void DisplayCourseDetails()
        {
            Console.WriteLine("Course Name: " + courseName);
            Console.WriteLine("Duration: " + duration + " months");
            Console.WriteLine("Fee: $" + fee);
            Console.WriteLine("Institute: " + instituteName);
            Console.WriteLine();
        }

        // class method - update institute name for all courses
        public static void UpdateInstituteName(string newName)
        {
            instituteName = newName;
            Console.WriteLine("Institute name updated to: " + instituteName);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            // create courses
            Course c1 = new Course("C# Programming", 6, 500.00);
            Course c2 = new Course("Web Development", 8, 750.00);

            // display course details
            Console.WriteLine("Initial Course Details:");
            c1.DisplayCourseDetails();
            c2.DisplayCourseDetails();

            // update institute name using class method
            Course.UpdateInstituteName("Advanced Tech Academy");

            // display details again to see updated institute name
            Console.WriteLine("After Institute Name Update:");
            c1.DisplayCourseDetails();
            c2.DisplayCourseDetails();

            Console.ReadLine();
        }
    }
}