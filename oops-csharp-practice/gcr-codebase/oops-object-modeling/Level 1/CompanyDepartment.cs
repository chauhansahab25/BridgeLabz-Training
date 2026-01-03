using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // employee class
    class Employee
    {
        public string Name;
        public string Position;

        public Employee(string name, string position)
        {
            Name = name;
            Position = position;
        }

        public void showEmployee()
        {
            Console.WriteLine("Employee: " + Name + " - " + Position);
        }
    }

    // department class - part of company (composition)
    class Department
    {
        public string DeptName;
        public List<Employee> employees;  // employees in this dept

        public Department(string name)
        {
            DeptName = name;
            employees = new List<Employee>();
        }

        // add employee to department
        public void addEmployee(Employee emp)
        {
            employees.Add(emp);
            Console.WriteLine("Added " + emp.Name + " to " + DeptName);
        }

        public void showDepartment()
        {
            Console.WriteLine("Department: " + DeptName);
            foreach (Employee emp in employees)
            {
                emp.showEmployee();
            }
            Console.WriteLine();
        }
    }

    // company class - owns departments (composition)
    class Company
    {
        public string CompanyName;
        public List<Department> departments;  // company owns departments

        public Company(string name)
        {
            CompanyName = name;
            departments = new List<Department>();
        }

        // create department (composition - dept belongs to company)
        public Department createDepartment(string deptName)
        {
            Department dept = new Department(deptName);
            departments.Add(dept);
            Console.WriteLine("Created " + deptName + " department in " + CompanyName);
            return dept;
        }

        public void showCompany()
        {
            Console.WriteLine("Company: " + CompanyName);
            foreach (Department dept in departments)
            {
                dept.showDepartment();
            }
        }

        // when company is deleted, all departments are deleted too (composition)
        public void closeCompany()
        {
            Console.WriteLine("Closing " + CompanyName + " - all departments will be removed");
            departments.Clear();  // remove all departments
        }
    }

    class Program
    {
        static void Main()
        {
            // create company
            Company company = new Company("Tech Corp");

            // create departments (composition)
            Department itDept = company.createDepartment("IT");
            Department hrDept = company.createDepartment("HR");

            // create employees
            Employee emp1 = new Employee("john", "developer");
            Employee emp2 = new Employee("alice", "manager");
            Employee emp3 = new Employee("bob", "hr specialist");

            // add employees to departments
            itDept.addEmployee(emp1);
            itDept.addEmployee(emp2);
            hrDept.addEmployee(emp3);

            // show company structure
            company.showCompany();

            // close company (composition - departments get deleted)
            company.closeCompany();

            Console.ReadLine();
        }
    }
}