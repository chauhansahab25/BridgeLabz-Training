using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // Employee class to store employee information
    class Employee
    {
        public string name;  // employee name
        public int id;       // employee id number
        public double salary; // employee salary
        
        // method to show employee details
        public void displayDetails()
        {
            Console.WriteLine("Employee ID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Salary: " + salary);
        }
    }

    class Program
    {
        static void Main()
        {
            // create new employee object
            Employee emp = new Employee();
            emp.name = "John";
            emp.id = 101;
            emp.salary = 45000;
            
            // display the employee info
            emp.displayDetails();
            Console.ReadLine(); // wait for user input
        }
    }
}