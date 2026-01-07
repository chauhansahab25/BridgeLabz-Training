using System;

namespace CG_Practice.oopsscenario.EmployeeWageComputation
{
    // utility class
    class EmployeeUtilityImpl
    {
        public void ProcessEmployeeWage()
        {
            EmployeeWage emp = new EmployeeWage("TechCorp");
            
            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();
            Console.Write("Enter employee ID: ");
            int id = int.Parse(Console.ReadLine());
            
            emp.AddEmployee(name, id);
            emp.CheckAttendance();
            emp.CalculateDailyWage();
            
            int monthlyWage = emp.CalculateMonthlyWage();
            Console.WriteLine("Monthly Wage: $" + monthlyWage);
            Console.WriteLine(emp.ToString());
        }
    }
}