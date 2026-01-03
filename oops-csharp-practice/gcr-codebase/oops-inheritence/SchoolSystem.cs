using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // base person class
    class Person
    {
        public string Name;  // person name
        public int Age;      // person age

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void DisplayRole()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Role: Person");
        }
    }

    // teacher class inherits from person (hierarchical)
    class Teacher : Person
    {
        public string Subject;  // subject taught

        public Teacher(string name, int age, string subject) 
            : base(name, age)  // call parent constructor
        {
            Subject = subject;
        }

        public override void DisplayRole()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Role: Teacher");
            Console.WriteLine("Subject: " + Subject);
        }
    }

    // student class inherits from person (hierarchical)
    class Student : Person
    {
        public string Grade;  // student grade/class

        public Student(string name, int age, string grade) 
            : base(name, age)
        {
            Grade = grade;
        }

        public override void DisplayRole()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Role: Student");
            Console.WriteLine("Grade: " + Grade);
        }
    }

    // staff class inherits from person (hierarchical)
    class Staff : Person
    {
        public string Department;  // staff department

        public Staff(string name, int age, string department) 
            : base(name, age)
        {
            Department = department;
        }

        public override void DisplayRole()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Role: Staff");
            Console.WriteLine("Department: " + Department);
        }
    }

    class Program
    {
        static void Main()
        {
            // create different school roles (hierarchical inheritance)
            Teacher teacher = new Teacher("mrs. smith", 35, "mathematics");
            Student student = new Student("john", 16, "10th grade");
            Staff staff = new Staff("mr. jones", 45, "administration");

            // display role information
            Console.WriteLine("Teacher Information:");
            teacher.DisplayRole();
            Console.WriteLine();

            Console.WriteLine("Student Information:");
            student.DisplayRole();
            Console.WriteLine();

            Console.WriteLine("Staff Information:");
            staff.DisplayRole();
            Console.WriteLine();

            // polymorphism with hierarchical inheritance
            Person[] people = { teacher, student, staff };
            Console.WriteLine("All School Members:");
            foreach (Person person in people)
            {
                person.DisplayRole();
                Console.WriteLine("---");
            }

            Console.ReadLine();
        }
    }
}