using System;

namespace CG_Practice.oopsscenario.EmployeeWageComputation
{
    // menu class - UC2
    class EmployeeMenu
    {
        public void ShowMenu()
        {
            Console.WriteLine("=== Employee Menu - UC2 ===");
            Console.WriteLine("1. Add Employee & Calculate Daily Wage");
            Console.WriteLine("2. Exit");
            
            int choice = int.Parse(Console.ReadLine());
            
            if (choice == 1)
            {
                EmployeeUtilityImpl util = new EmployeeUtilityImpl();
                util.ProcessEmployee();
            }
        }
    }
}