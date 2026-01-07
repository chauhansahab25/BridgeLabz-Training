using System;

namespace CG_Practice.oopsscenario.EmployeeWageComputation
{
    // menu class - UC3
    class EmployeeWageMenu
    {
        public void ShowMenu()
        {
            Console.WriteLine("=== Employee Wage Menu - UC3 ===");
            Console.WriteLine("1. Add Employee & Calculate Daily Wage (Part Time Support)");
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