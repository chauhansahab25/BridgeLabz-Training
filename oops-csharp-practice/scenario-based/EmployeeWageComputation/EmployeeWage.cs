using System;

namespace CG_Practice.oopsscenario.EmployeeWageComputation
{
    // employee wage class
    class EmployeeWage : IEmployeeWage
    {
        public const int WagePerHour = 20;
        public const int FullDayHour = 8;
        public const int PartTimeHour = 4;
        public const int WorkingDaysPerMonth = 20;
        
        // attendance types
        public const int IsAbsent = 0;
        public const int IsPartTime = 1;
        public const int IsFullTime = 2;
        
        public string CompanyName;
        public string EmployeeName;
        public int EmployeeId;
        public int AttendanceType;
        public int DailyWage;
        public int MonthlyWage;
        public int WorkHours;
        public int TotalWorkingDays;

        public EmployeeWage(string company)
        {
            CompanyName = company;
            EmployeeName = "";
            EmployeeId = 0;
            AttendanceType = 0;
            DailyWage = 0;
            MonthlyWage = 0;
            WorkHours = 0;
            TotalWorkingDays = WorkingDaysPerMonth;
        }

        public void AddEmployee(string name, int id)
        {
            EmployeeName = name;
            EmployeeId = id;
            Console.WriteLine("Employee added: " + name + " (ID: " + id + ")");
        }

        public void CheckAttendance()
        {
            Console.WriteLine("Select attendance type for " + EmployeeName + ":");
            Console.WriteLine("0 - Absent, 1 - Part Time, 2 - Full Time");
            AttendanceType = int.Parse(Console.ReadLine());

            switch (AttendanceType)
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

        public int CalculateDailyWage()
        {
            switch (AttendanceType)
            {
                case IsPartTime:
                    WorkHours = PartTimeHour;
                    DailyWage = WagePerHour * PartTimeHour;
                    return DailyWage;
                case IsFullTime:
                    WorkHours = FullDayHour;
                    DailyWage = WagePerHour * FullDayHour;
                    return DailyWage;
                case IsAbsent:
                    WorkHours = 0;
                    DailyWage = 0;
                    return 0;
                default:
                    return 0;
            }
        }

        public int CalculateMonthlyWage()
        {
            MonthlyWage = DailyWage * TotalWorkingDays;
            return MonthlyWage;
        }

        public override string ToString()
        {
            string status = AttendanceType == IsPartTime ? "Part Time" : AttendanceType == IsFullTime ? "Full Time" : "Absent";
            return "Company: " + CompanyName + " | Employee: " + EmployeeName + " (ID: " + EmployeeId + ") | Status: " + status + " | Work Hours: " + WorkHours + " | Daily Wage: $" + DailyWage + " | Monthly Wage: $" + MonthlyWage + " | Working Days: " + TotalWorkingDays;
        }
    }
}