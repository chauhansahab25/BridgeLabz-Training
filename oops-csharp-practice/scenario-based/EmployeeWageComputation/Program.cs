using System;

namespace CG_Practice.oopsscenario.EmployeeWageComputation
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program on Master Branch - UC3");
            Console.WriteLine();

            EmployeeWageMenu menu = new EmployeeWageMenu();
            menu.ShowMenu();

            Console.ReadKey();
        }
    }
}