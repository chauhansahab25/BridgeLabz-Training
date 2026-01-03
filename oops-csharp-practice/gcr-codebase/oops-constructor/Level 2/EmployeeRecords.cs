using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // employee class
    class Employee
    {
        public int employeeID;          // everyone can see
        protected string department;    // only this class and child classes  
        private double salary;          // only this class

        public Employee(int id, string dept, double sal)
        {
            employeeID = id;
            department = dept;
            salary = sal;
        }

        // get salary amount
        public double getSalary()
        {
            return salary;
        }

        // change salary
        public void setSalary(double newSalary)
        {
            salary = newSalary;
            Console.WriteLine("Salary updated to: $" + salary);
        }

        // give raise
        public void giveRaise(double amount)
        {
            salary = salary + amount;
            Console.WriteLine("Raise given! New salary: $" + salary);
        }

        public void showEmployee()
        {
            Console.WriteLine("ID: " + employeeID);
            Console.WriteLine("Department: " + department);
            Console.WriteLine("Salary: $" + salary);
        }
    }

    // manager inherits from employee
    class Manager : Employee
    {
        public int teamSize;
        public string projectName;

        public Manager(int id, string dept, double sal, int team, string project) 
            : base(id, dept, sal)
        {
            teamSize = team;
            projectName = project;
        }

        // manager specific method
        public void assignProject(string newProject)
        {
            projectName = newProject;
            Console.WriteLine("New project assigned: " + projectName);
        }

        public void showManagerDetails()
        {
            Console.WriteLine("Manager Info:");
            Console.WriteLine("ID: " + employeeID);          // public - can access
            Console.WriteLine("Department: " + department);   // protected - can access
            Console.WriteLine("Salary: $" + getSalary());    // private - need method
            Console.WriteLine("Team Size: " + teamSize);
            Console.WriteLine("Project: " + projectName);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            Employee emp1 = new Employee(101, "IT", 50000);
            emp1.showEmployee();
            Console.WriteLine();

            emp1.giveRaise(5000);
            Console.WriteLine();

            Manager mgr1 = new Manager(201, "Development", 80000, 5, "Web App");
            mgr1.showManagerDetails();
            mgr1.assignProject("Mobile App");

            Console.ReadLine();
        }
    }
}