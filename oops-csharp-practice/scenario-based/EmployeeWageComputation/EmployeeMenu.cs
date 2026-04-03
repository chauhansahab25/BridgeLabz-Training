using System;

namespace CG_Practice.oopsscenario.EmployeeWageComputation
{
    // menu class for employee operations
    class EmployeeMenu
    {
        private EmployeeUtilityImpl utility;

        public void ShowMenu()
        {
            utility = new EmployeeUtilityImpl();
            Console.WriteLine("1. Add Employee ");
            Console.WriteLine("2. Exit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    utility.ProcessEmployee();
                    break;
                case 2:
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
        }
    }
}