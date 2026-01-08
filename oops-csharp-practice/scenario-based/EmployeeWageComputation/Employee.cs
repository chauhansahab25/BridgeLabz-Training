using System;

namespace CG_Practice.oopsscenario.EmployeeWageComputation
{
    // employee class with random attendance
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

        public void AddEmployee(string name, int id)
        {
            EmployeeName = name;
            EmployeeId = id;
            Console.WriteLine("Employee added: " + name + " (ID: " + id + ")");
        }

        public void CheckAttendance()
        {
            Random random = new Random();
            IsPresent = random.Next(0, 2); // Random 0 or 1
            
            if (IsPresent == 1)
            {
                Console.WriteLine("Employee " + EmployeeName + " is Present (Random Check)");
            }
            else
            {
                Console.WriteLine("Employee " + EmployeeName + " is Absent (Random Check)");
            }
        }

        public int CalculateDailyWage()
        {
            if (IsPresent == 1)
            {
                DailyWage = WagePerHour * FullDayHour;
                return DailyWage;
            }
            DailyWage = 0;
            return 0;
        }

        public override string ToString()
        {
            return "Company: " + CompanyName + " | Employee: " + EmployeeName + " (ID: " + EmployeeId + ") | Attendance: " + (IsPresent == 1 ? "Present" : "Absent") + " | Daily Wage: $" + DailyWage;
        }
    }
}