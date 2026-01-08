using System;

namespace CG_Practice.oopsscenario.EmployeeWageComputation
{
    // menu class for employee operations
    class EmployeeMenu
    {
        private EmployeeUtilityImpl utility;

        public EmployeeMenu()
        {
            utility = new EmployeeUtilityImpl();
        }

        public void ShowMenu()
        {
            Console.WriteLine("Employee Wage Computation - UC3");
            Console.WriteLine("Random Attendance Check Feature");
            Console.WriteLine();

            utility.ProcessEmployee();

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
        }
    }
}