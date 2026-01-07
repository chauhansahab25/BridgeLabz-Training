using System;

namespace CG_Practice.oopsscenario.EmployeeWageComputation
{
    // employee wage class
    class EmployeeWage : IEmployeeWage
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program on Master Branch");
            Console.WriteLine();

            EmployeeWage emp = new EmployeeWage();
            emp.CheckAttendance();

            Console.ReadKey();
        }

        public void CheckAttendance()
        {
            Random rand = new Random();
            int attendance = rand.Next(0, 2); // 0 or 1

            if (attendance == 1)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}