using System;
using System.Collections.Generic;

namespace EmployeeManagement
{
    // abstract employee class
    abstract class Employee
    {
        private int employeeId;  // private field
        private string name;
        private double baseSalary;

        // properties for encapsulation
        public int EmployeeId 
        { 
            get { return employeeId; } 
            set { employeeId = value; } 
        }
        
        public string Name 
        { 
            get { return name; } 
            set { name = value; } 
        }
        
        public double BaseSalary 
        { 
            get { return baseSalary; } 
            set { baseSalary = value; } 
        }

        // constructor
        public Employee(int id, string empName, double salary)
        {
            employeeId = id;
            name = empName;
            baseSalary = salary;
        }

        // abstract method - must be implemented by child classes
        public abstract double CalculateSalary();

        // concrete method
        public void DisplayDetails()
        {
            Console.WriteLine("ID: " + employeeId);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Base Salary: $" + baseSalary);
            Console.WriteLine("Total Salary: $" + CalculateSalary());
        }
    }

    // interface for department
    interface IDepartment
    {
        void AssignDepartment(string dept);
        string GetDepartmentDetails();
    }

    // full time employee class
    class FullTimeEmployee : Employee, IDepartment
    {
        private string department;

        public FullTimeEmployee(int id, string name, double salary) 
            : base(id, name, salary)
        {
        }

        // implement abstract method
        public override double CalculateSalary()
        {
            return BaseSalary + (BaseSalary * 0.2);  // 20% bonus
        }

        // implement interface
        public void AssignDepartment(string dept)
        {
            department = dept;
        }

        public string GetDepartmentDetails()
        {
            return department;
        }
    }

    // part time employee class
    class PartTimeEmployee : Employee, IDepartment
    {
        private int hoursWorked;
        private string department;

        public PartTimeEmployee(int id, string name, double hourlyRate, int hours) 
            : base(id, name, hourlyRate)
        {
            hoursWorked = hours;
        }

        // implement abstract method
        public override double CalculateSalary()
        {
            return BaseSalary * hoursWorked;  // hourly rate * hours
        }

        // implement interface
        public void AssignDepartment(string dept)
        {
            department = dept;
        }

        public string GetDepartmentDetails()
        {
            return department;
        }
    }

    class Program
    {
        static void Main()
        {
            // create list of employees (polymorphism)
            List<Employee> employees = new List<Employee>();

            // create different employee types
            FullTimeEmployee ft1 = new FullTimeEmployee(101, "john", 5000);
            ft1.AssignDepartment("IT");

            PartTimeEmployee pt1 = new PartTimeEmployee(102, "alice", 25, 80);
            pt1.AssignDepartment("HR");

            // add to list
            employees.Add(ft1);
            employees.Add(pt1);

            // display all employees using polymorphism
            Console.WriteLine("Employee Management System");
            Console.WriteLine("==========================");

            foreach (Employee emp in employees)
            {
                emp.DisplayDetails();  // polymorphic call
                
                // check if employee has department
                if (emp is IDepartment)
                {
                    IDepartment deptEmp = (IDepartment)emp;
                    Console.WriteLine("Department: " + deptEmp.GetDepartmentDetails());
                }
                
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}