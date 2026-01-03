using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // base course class (level 1)
    class Course
    {
        public string CourseName;  // course name
        public int Duration;       // course duration in hours

        public Course(string courseName, int duration)
        {
            CourseName = courseName;
            Duration = duration;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Course: " + CourseName);
            Console.WriteLine("Duration: " + Duration + " hours");
        }
    }

    // online course class inherits from course (level 2)
    class OnlineCourse : Course
    {
        public string Platform;    // platform name
        public bool IsRecorded;    // is course recorded

        public OnlineCourse(string courseName, int duration, string platform, bool isRecorded) 
            : base(courseName, duration)  // call parent constructor
        {
            Platform = platform;
            IsRecorded = isRecorded;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();  // call parent method
            Console.WriteLine("Platform: " + Platform);
            Console.WriteLine("Recorded: " + (IsRecorded ? "Yes" : "No"));
        }
    }

    // paid online course class inherits from online course (level 3)
    class PaidOnlineCourse : OnlineCourse
    {
        public double Fee;       // course fee
        public double Discount;  // discount percentage

        public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount) 
            : base(courseName, duration, platform, isRecorded)  // call parent constructor
        {
            Fee = fee;
            Discount = discount;
        }

        public double getFinalPrice()
        {
            return Fee - (Fee * Discount / 100);  // calculate discounted price
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();  // call parent method
            Console.WriteLine("Fee: $" + Fee);
            Console.WriteLine("Discount: " + Discount + "%");
            Console.WriteLine("Final Price: $" + getFinalPrice());
        }
    }

    class Program
    {
        static void Main()
        {
            // create courses at different levels (multilevel inheritance)
            Course course1 = new Course("basic programming", 40);
            OnlineCourse course2 = new OnlineCourse("web development", 60, "udemy", true);
            PaidOnlineCourse course3 = new PaidOnlineCourse("advanced c#", 80, "coursera", true, 199.99, 20);

            // display course info
            Console.WriteLine("Basic Course:");
            course1.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("Online Course:");
            course2.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("Paid Online Course:");
            course3.DisplayInfo();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}