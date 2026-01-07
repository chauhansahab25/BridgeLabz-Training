using System;

namespace CG_Practice.oopsscenario.EmployeeWageComputation
{
    // employee wage class - UC3
    class EmployeeWage : IEmployeeWage
    {
        public const int WagePerHour = 20;
        public const int FullDayHour = 8;
        public const int PartTimeHour = 4; // uc3 function
        
        public string CompanyName;
        public string EmployeeName;
        public int EmployeeId;
        public int AttendanceType;
        public int DailyWage;
        public int WorkHours;

        public EmployeeWage(string company)
        {
            CompanyName = company;
            EmployeeName = "";
            EmployeeId = 0;
            AttendanceType = 0;
            DailyWage = 0;
            WorkHours = 0;
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

            if (AttendanceType == 1)
            {
                Console.WriteLine("Employee is Part Time"); // uc3 function
            }
            else if (AttendanceType == 2)
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
            if (AttendanceType == 1) // uc3 function - part time
            {
                WorkHours = PartTimeHour;
                DailyWage = WagePerHour * PartTimeHour;
                return DailyWage;
            }
            else if (AttendanceType == 2) // uc3 function - full time
            {
                WorkHours = FullDayHour;
                DailyWage = WagePerHour * FullDayHour;
                return DailyWage;
            }
            WorkHours = 0;
            DailyWage = 0;
            return 0; // absent
        }

        public override string ToString()
        {
            string status = AttendanceType == 1 ? "Part Time" : AttendanceType == 2 ? "Full Time" : "Absent";
            return "Company: " + CompanyName + " | Employee: " + EmployeeName + " (ID: " + EmployeeId + ") | Status: " + status + " | Work Hours: " + WorkHours + " | Daily Wage: $" + DailyWage;
        }
    }
}