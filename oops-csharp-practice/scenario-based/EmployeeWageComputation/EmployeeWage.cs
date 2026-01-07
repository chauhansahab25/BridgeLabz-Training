using System;

namespace CG_Practice.oopsscenario.EmployeeWageComputation
{
    // employee wage class
    class EmployeeWage : IEmployeeWage
    {
        public const int WagePerHour = 20;
        public const int FullDayHour = 8;
        public const int PartTimeHour = 4; // uc3 function

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

            if (attendance == 1)
            {
                Console.WriteLine("Employee is Part Time"); // uc3 function
            }
            else if (attendance == 2)
            {
                Console.WriteLine("Employee is Full Time"); // uc3 function
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }

        // uc2 function
        public int CalculateDailyWage()
        {
            Random rand = new Random();
            int attendance = rand.Next(0, 3); // uc3 function

            if (attendance == 1) // uc3 function - part time
            {
                return WagePerHour * PartTimeHour;
            }
            else if (attendance == 2) // uc3 function - full time
            {
                return WagePerHour * FullDayHour;
            }
            return 0; // absent
        }
    }
}