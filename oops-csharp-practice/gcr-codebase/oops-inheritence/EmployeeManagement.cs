using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // base employee class
    class Employee
    {
        public string Name;    // employee name
        public int Id;         // employee id
        public double Salary;  // employee salary

        public Employee(string name, int id, double salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }

        // virtual method - can be overridden
        public virtual void DisplayDetails()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Salary: $" + Salary);
        }
    }

    // manager class inherits from employee
    class Manager : Employee
    {
        public int TeamSize;  // additional attribute for manager

        public Manager(string name, int id, double salary, int teamSize) 
            : base(name, id, salary)  // call parent constructor
        {
            TeamSize = teamSize;
        }

        // override parent method
        public override void DisplayDetails()
        {
            base.DisplayDetails();  // call parent method first
            Console.WriteLine("Role: Manager");
            Console.WriteLine("Team Size: " + TeamSize);
        }
    }

    // developer class inherits from employee
    class Developer : Employee
    {
        public string ProgrammingLanguage;  // additional attribute

        public Developer(string name, int id, double salary, string language) 
            : base(name, id, salary)
        {
            ProgrammingLanguage = language;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Role: Developer");
            Console.WriteLine("Programming Language: " + ProgrammingLanguage);
        }
    }

    // intern class inherits from employee
    class Intern : Employee
    {
        public string InternshipDuration;  // additional attribute

        public Intern(string name, int id, double salary, string duration) 
            : base(name, id, salary)
        {
            InternshipDuration = duration;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Role: Intern");
            Console.WriteLine("Internship Duration: " + InternshipDuration);
        }
    }

    class Program
    {
        static void Main()
        {
            // create different types of employees
            Manager mgr = new Manager("alice", 101, 80000, 5);
            Developer dev = new Developer("bob", 102, 60000, "C#");
            Intern intern = new Intern("charlie", 103, 20000, "6 months");

            // display employee details
            Console.WriteLine("Manager Details:");
            mgr.DisplayDetails();
            Console.WriteLine();

            Console.WriteLine("Developer Details:");
            dev.DisplayDetails();
            Console.WriteLine();

            Console.WriteLine("Intern Details:");
            intern.DisplayDetails();
            Console.WriteLine();

            // polymorphism with employee array
            Employee[] employees = { mgr, dev, intern };
            Console.WriteLine("All Employees:");
            foreach (Employee emp in employees)
            {
                emp.DisplayDetails();  // calls overridden method
                Console.WriteLine("---");
            }

            Console.ReadLine();
        }
    }
}