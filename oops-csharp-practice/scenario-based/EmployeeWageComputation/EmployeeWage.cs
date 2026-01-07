using System;

namespace CG_Practice.oopsscenario.EmployeeWageComputation
{
    // employee wage class - UC2
    class EmployeeWage : IEmployeeWage
    {
        public const int WagePerHour = 20;
        public const int FullDayHour = 8;
        
        public string CompanyName;
        public string EmployeeName;
        public int EmployeeId;
        public int IsPresent;
        public int DailyWage;

        public EmployeeWage(string company)
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
            Console.Write("Is " + EmployeeName + " present? (1 for Yes, 0 for No): ");
            IsPresent = int.Parse(Console.ReadLine());

            if (IsPresent == 1)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }

        // uc2 function
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