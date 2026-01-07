using System;

namespace CG_Practice.oopsscenario.EmployeeWageComputation
{
    // employee wage class
    class EmployeeWage : IEmployeeWage
    {
        public const int WagePerHour = 20;
        public const int FullDayHour = 8;
        public const int PartTimeHour = 4; // uc3 function
        public const int WorkingDaysPerMonth = 20; // uc5 function
        public const int MaxWorkingHours = 100; // uc6 function
        public const int MaxWorkingDays = 20; // uc6 function
        // uc4 function - constants for switch case
        public const int IsAbsent = 0;
        public const int IsPartTime = 1;
        public const int IsFullTime = 2;

        static void Main()
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program on Master Branch");
            Console.WriteLine();

            EmployeeWage emp = new EmployeeWage();
            
            emp.CalculateWageTillCondition(); // uc6 function

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

        // uc5 function
        public int CalculateMonthlyWage()
        {
            int totalWage = 0;
            for (int day = 1; day <= WorkingDaysPerMonth; day++)
            {
                totalWage += CalculateDailyWage();
            }
            return totalWage;
        }

        // uc6 function
        public void CalculateWageTillCondition()
        {
            Random rand = new Random();
            int totalWage = 0;
            int totalHours = 0;
            int totalDays = 0;

            while (totalHours < MaxWorkingHours && totalDays < MaxWorkingDays)
            {
                totalDays++;
                int attendance = rand.Next(0, 3);
                int dailyWage = 0;
                int workHours = 0;

                switch (attendance)
                {
                    case IsPartTime:
                        workHours = PartTimeHour;
                        dailyWage = WagePerHour * PartTimeHour;
                        break;
                    case IsFullTime:
                        workHours = FullDayHour;
                        dailyWage = WagePerHour * FullDayHour;
                        break;
                    case IsAbsent:
                        workHours = 0;
                        dailyWage = 0;
                        break;
                }

                totalHours += workHours;
                totalWage += dailyWage;
            }

            Console.WriteLine("Total Days: " + totalDays);
            Console.WriteLine("Total Hours: " + totalHours);
            Console.WriteLine("Total Wage: $" + totalWage);
        }
    }
}