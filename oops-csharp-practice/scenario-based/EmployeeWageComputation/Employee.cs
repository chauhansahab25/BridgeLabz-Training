using System;

namespace CG_Practice.oopsscenario.EmployeeWageComputation
{
    // employee class
    class Employee 
    {
        public const int WagePerHour = 20;
        public const int FullDayHour = 8;
        public const int PartTimeHour = 4;
        public const int WorkingDaysPerMonth = 20;

        public string CompanyName;
        public string EmployeeName;
        public int EmployeeId;
        public int IsPresent;
        public int DailyWage;
        public int MonthlyWage;

        public Employee(string company)
        {
            CompanyName = company;
            EmployeeName = "";
            EmployeeId = 0;
            IsPresent = 0;
            DailyWage = 0;
            MonthlyWage = 0;
        }


        public override string ToString()
        {
            string status = "";
            switch (IsPresent)
            {
                case 0:
                    status = "Absent";
                    break;
                case 1:
                    status = "Part Time";
                    break;
                case 2:
                    status = "Full Time";
                    break;
                default:
                    status = "Unknown";
                    break;
            }
            return "Company: " + CompanyName + " | Employee: " + EmployeeName + " (ID: " + EmployeeId + ") | Status: " + status + " | Daily Wage: $" + DailyWage + " | Monthly Wage: $" + MonthlyWage;
        }
    }
}