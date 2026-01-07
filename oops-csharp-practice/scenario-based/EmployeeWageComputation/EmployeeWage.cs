using System;

namespace CG_Practice.oopsscenario.EmployeeWageComputation
{
    // employee wage class
    class EmployeeWage : IEmployeeWage
    {
        public const int WagePerHour = 20;
        public const int FullDayHour = 8;
        public const int PartTimeHour = 4; // uc3 function
        // uc4 function - constants for switch case
        public const int IsAbsent = 0;
        public const int IsPartTime = 1;
        public const int IsFullTime = 2;

        static void Main()
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program on Master Branch");
            Console.WriteLine();

            EmployeeWage emp = new EmployeeWage();
            emp.CheckAttendance();
            
            int dailyWage = emp.CalculateDailyWage(); // uc2 function
            Console.WriteLine("Daily Wage: $" + dailyWage);

            Console.ReadKey();
        }

        public void CheckAttendance()
        {
            Random rand = new Random();
            int attendance = rand.Next(0, 3); // uc3 function - 0, 1, or 2

            // uc4 function - switch case
            switch (attendance)
            {
                case IsPartTime:
                    Console.WriteLine("Employee is Part Time");
                    break;
                case IsFullTime:
                    Console.WriteLine("Employee is Full Time");
                    break;
                case IsAbsent:
                    Console.WriteLine("Employee is Absent");
                    break;
            }
        }

        // uc2 function
        public int CalculateDailyWage()
        {
            Random rand = new Random();
            int attendance = rand.Next(0, 3); // uc3 function

            // uc4 function - switch case
            switch (attendance)
            {
                case IsPartTime:
                    return WagePerHour * PartTimeHour;
                case IsFullTime:
                    return WagePerHour * FullDayHour;
                case IsAbsent:
                    return 0;
                default:
                    return 0;
            }
        }
    }
}