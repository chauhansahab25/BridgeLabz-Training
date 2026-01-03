using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // employee class
    class Employee
    {
        // static variables - shared by all employees
        public static string CompanyName = "Tech Corp";
        public static int totalEmployees = 0;

        // readonly - cant change after assignment
        public readonly int Id;
        
        // regular variables
        public string Name;
        public string Designation;

        // constructor using this keyword
        public Employee(string Name, int Id, string Designation)
        {
            this.Name = Name;                // this resolves ambiguity
            this.Id = Id;                    // this resolves ambiguity
            this.Designation = Designation;  // this resolves ambiguity
            totalEmployees++;
        }

        // static method
        public static void DisplayTotalEmployees()
        {
            Console.WriteLine("Total Employees: " + totalEmployees);
            Console.WriteLine("Company: " + CompanyName);
        }

        public void showEmployee()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Designation: " + Designation);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            // create employees
            Employee emp1 = new Employee("John", 101, "Developer");
            Employee emp2 = new Employee("Alice", 102, "Manager");

            // using is operator to check type
            object obj = emp1;
            if (obj is Employee)
            {
                Console.WriteLine("Object is Employee - showing details:");
                emp1.showEmployee();
            }

            emp2.showEmployee();

            // call static method
            Employee.DisplayTotalEmployees();

            Console.ReadLine();
        }
    }
}