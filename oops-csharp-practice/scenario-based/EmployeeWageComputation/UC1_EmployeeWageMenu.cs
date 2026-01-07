using System;

namespace CG_Practice.oopsscenario.EmployeeWageComputation
{
    // menu class - UC1
    class EmployeeWageMenu
    {
        public void ShowMenu()
        {
            Console.WriteLine("=== Employee Wage Menu - UC1 ===");
            Console.WriteLine("1. Add Employee & Check Attendance");
            Console.WriteLine("2. Exit");
            
            int choice = int.Parse(Console.ReadLine());
            
            if (choice == 1)
            {
                EmployeeUtilityImpl util = new EmployeeUtilityImpl();
                util.ProcessEmployeeWage();
            }
        }
    }
}