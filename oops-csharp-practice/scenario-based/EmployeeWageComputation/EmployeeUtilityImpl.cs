using System;

namespace CG_Practice.oopsscenario.EmployeeWageComputation
{
    // utility class - UC1
    class EmployeeUtilityImpl
    {
        public void ProcessEmployee()
        {
            Employee emp = new Employee("TechCorp");
            
            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();
            Console.Write("Enter employee ID: ");
            int id = int.Parse(Console.ReadLine());
            
            emp.AddEmployee(name, id);
            emp.CheckAttendance();
            Console.WriteLine(emp.ToString());
        }
    }
}