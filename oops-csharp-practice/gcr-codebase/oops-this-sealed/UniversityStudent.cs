using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    class Student
    {
        static string UniversityName = "state university";  // same uni for all
        static int totalStudents = 0;

        readonly int RollNumber;  // roll no cant change
        
        string Name;
        string Grade;

        public Student(string Name, int RollNumber, string Grade)
        {
            this.Name = Name;                // this to resolve name issue
            this.RollNumber = RollNumber;    
            this.Grade = Grade;              
            totalStudents++;
        }

        static void DisplayTotalStudents()
        {
            Console.WriteLine("total students: " + totalStudents);
            Console.WriteLine("university: " + UniversityName);
        }

        void showStudent()
        {
            Console.WriteLine("student: " + Name);
            Console.WriteLine("roll: " + RollNumber);
            Console.WriteLine("grade: " + Grade);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            Student s1 = new Student("john", 101, "A");
            Student s2 = new Student("alice", 102, "B+");

            object obj = s1;
            if (obj is Student)  // check if student type
            {
                Console.WriteLine("its student:");
                s1.showStudent();
            }

            s2.showStudent();
            Student.DisplayTotalStudents();

            Console.ReadLine();
        }
    }
}