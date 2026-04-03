using System;

namespace CG_Practice.oopsscenario.EmployeeWageComputation
{
    // employee class
    class Employee : IEmployee
    {
        public string CompanyName;
        public string EmployeeName;
        public int EmployeeId;
        public int IsPresent;
        public int DailyWage;
        public int MonthlyWage;
        public int TotalWorkingHours;
        public int TotalWorkingDays;

        public Employee(string company)
        {
            CompanyName = company;
            EmployeeName = "";
            EmployeeId = 0;
            IsPresent = 0;
            DailyWage = 0;
            MonthlyWage = 0;
            TotalWorkingHours = 0;
            TotalWorkingDays = 0;
        }

        public void AddEmployee(string name, int id)
        {
            // Implementation moved to EmployeeUtilityImpl
        }

        public void CheckAttendance()
        {
            // Implementation moved to EmployeeUtilityImpl
        }

        public int CalculateDailyWage()
        {
            // Implementation moved to EmployeeUtilityImpl
            return DailyWage;
        }

        public int CalculateMonthlyWage()
        {
            // Implementation moved to EmployeeUtilityImpl
            return MonthlyWage;
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
            return "Company: " + CompanyName + " | Employee: " + EmployeeName + " (ID: " + EmployeeId + ") | Total Hours: " + TotalWorkingHours + " | Total Days: " + TotalWorkingDays + " | Monthly Wage: $" + MonthlyWage;
        }
    }
}