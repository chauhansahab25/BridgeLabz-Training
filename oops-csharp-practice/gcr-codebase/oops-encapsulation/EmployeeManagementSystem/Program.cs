using System;
using System.Collections.Generic;

namespace CG_Practice.oopscsharp.EmployeeManagementSystem
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== EMPLOYEE MANAGEMENT SYSTEM ===");
            Console.WriteLine();

            // create list of employees using polymorphism
            List<Employee> employees = new List<Employee>();

            employees.Add(new FullTimeEmployee(101, "John Smith", 5000, 1000));
            employees.Add(new PartTimeEmployee(102, "Sarah Johnson", 0, 120, 25));
            employees.Add(new FullTimeEmployee(103, "Mike Brown", 4500, 800));
            employees.Add(new PartTimeEmployee(104, "Lisa Davis", 0, 80, 30));

            // assign departments
            employees[0].AssignDepartment("IT");
            employees[1].AssignDepartment("Marketing");
            employees[2].AssignDepartment("Finance");
            employees[3].AssignDepartment("HR");

            // display all employee details using polymorphism
            Console.WriteLine("=== ALL EMPLOYEES ===");
            foreach (Employee emp in employees)
            {
                emp.DisplayDetails(); // calls overridden method based on actual type
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}