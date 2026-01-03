using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // student class for university
    class Student
    {
        // static variables - shared by all students
        public static string UniversityName = "State University";
        public static int totalStudents = 0;

        // readonly - cant change after assignment
        public readonly int RollNumber;
        
        // regular variables
        public string Name;
        public string Grade;

        // constructor using this keyword
        public Student(string Name, int RollNumber, string Grade)
        {
            this.Name = Name;                // this resolves ambiguity
            this.RollNumber = RollNumber;    // this resolves ambiguity
            this.Grade = Grade;              // this resolves ambiguity
            totalStudents++;
        }

        // static method
        public static void DisplayTotalStudents()
        {
            Console.WriteLine("Total Students: " + totalStudents);
            Console.WriteLine("University: " + UniversityName);
        }

        public void showStudent()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Roll: " + RollNumber);
            Console.WriteLine("Grade: " + Grade);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            // create students
            Student s1 = new Student("John", 101, "A");
            Student s2 = new Student("Alice", 102, "B+");

            // using is operator to check type
            object obj = s1;
            if (obj is Student)
            {
                Console.WriteLine("Object is Student - showing details:");
                s1.showStudent();
            }

            s2.showStudent();

            // call static method
            Student.DisplayTotalStudents();

            Console.ReadLine();
        }
    }
}