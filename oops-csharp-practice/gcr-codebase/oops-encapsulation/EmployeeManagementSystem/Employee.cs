using System;

namespace CG_Practice.oopscsharp.EmployeeManagementSystem
{
    // abstract employee class
    abstract class Employee : IDepartment
    {
        private int employeeId;
        private string name;
        private double baseSalary;
        private string department;

        // properties for encapsulation
        public int EmployeeId { get { return employeeId; } set { employeeId = value; } }
        public string Name { get { return name; } set { name = value; } }
        public double BaseSalary { get { return baseSalary; } set { baseSalary = value; } }
        public string Department { get { return department; } set { department = value; } }

        public Employee(int id, string empName, double salary)
        {
            employeeId = id;
            name = empName;
            baseSalary = salary;
            department = "Not Assigned";
        }

        // abstract method to be implemented by child classes
        public abstract double CalculateSalary();

        public void DisplayDetails()
        {
            Console.WriteLine("ID: " + employeeId + " | Name: " + name);
            Console.WriteLine("Department: " + department);
            Console.WriteLine("Calculated Salary: $" + CalculateSalary());
            Console.WriteLine("------------------------");
        }

        public void AssignDepartment(string dept)
        {
            department = dept;
        }

        public string GetDepartmentDetails()
        {
            return department;
        }
    }
}