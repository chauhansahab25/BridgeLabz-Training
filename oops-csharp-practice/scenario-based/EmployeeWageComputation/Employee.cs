using System;

namespace CG_Practice.oopsscenario.EmployeeWageComputation
{
    // employee class
    class Employee : IEmployee
    {
        public const int WagePerHour = 20;
        public const int FullDayHour = 8;
        public const int PartTimeHour = 4;
        
        public string CompanyName;
        public string EmployeeName;
        public int EmployeeId;
        public int IsPresent;
        public int DailyWage;

        public Employee(string company)
        {
            CompanyName = company;
            EmployeeName = "";
            EmployeeId = 0;
            IsPresent = 0;
            DailyWage = 0;
        }

        
    
        public override string ToString()
        {
            return "Company: " + CompanyName + " | Employee: " + EmployeeName + " (ID: " + EmployeeId + ") | Attendance: " + (IsPresent == 1 ? "Present" : "Absent") + " | Daily Wage: $" + DailyWage;
        }
    }
}