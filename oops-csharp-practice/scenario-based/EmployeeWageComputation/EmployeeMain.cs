using System;

namespace CG_Practice.oopsscenario.EmployeeWageComputation
{
    class EmployeeMain
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program - UC3");
            Console.WriteLine();

            EmployeeMenu menu = new EmployeeMenu();
            menu.ShowMenu();

            Console.ReadKey();
        }
    }
}