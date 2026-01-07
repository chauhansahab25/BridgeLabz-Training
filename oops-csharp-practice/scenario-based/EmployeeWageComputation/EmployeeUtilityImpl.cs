using System;

namespace CG_Practice.oopsscenario.EmployeeWageComputation
{
    // utility implementation class - UC4
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
            
            int dailyWage = emp.CalculateDailyWage(); // uc2 function
            Console.WriteLine("Daily Wage: $" + dailyWage);
            Console.WriteLine(emp.ToString());
        }
    }
}