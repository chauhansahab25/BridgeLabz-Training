using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    class Employee
    {
        static string CompanyName = "tech corp";  // company name for all
        static int totalEmployees = 0;

        readonly int Id;  // id cant change
        
        string Name;
        string Designation;

        public Employee(string Name, int Id, string Designation)
        {
            this.Name = Name;                // this keyword to resolve name conflict
            this.Id = Id;                    
            this.Designation = Designation;  
            totalEmployees++;
        }

        static void DisplayTotalEmployees()
        {
            Console.WriteLine("total emps: " + totalEmployees);
            Console.WriteLine("company: " + CompanyName);
        }

        void showEmployee()
        {
            Console.WriteLine("name: " + Name);
            Console.WriteLine("id: " + Id);
            Console.WriteLine("job: " + Designation);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            Employee emp1 = new Employee("john", 101, "developer");
            Employee emp2 = new Employee("alice", 102, "manager");

            object obj = emp1;
            if (obj is Employee)  // check type
            {
                Console.WriteLine("its employee object:");
                emp1.showEmployee();
            }

            emp2.showEmployee();
            Employee.DisplayTotalEmployees();

            Console.ReadLine();
        }
    }
}