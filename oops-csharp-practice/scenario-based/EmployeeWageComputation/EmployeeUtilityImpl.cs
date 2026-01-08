using System;

namespace CG_Practice.oopsscenario.EmployeeWageComputation
{
    // utility class for employee operations
    class EmployeeUtilityImpl
    {
        public const int WagePerHour = 20;
        public const int FullDayHour = 8;
        public const int PartTimeHour = 4;
        public const int WorkingDaysPerMonth = 20;
        public const int MaxWorkingHours = 100;
        public const int DaysInMonth = 30;

        private Employee employee;

        public EmployeeUtilityImpl()
        {
            employee = new Employee("BridgeLabz Solutions");
        }

        public void AddEmployee(string name, int id)
        {
            employee.EmployeeName = name;
            employee.EmployeeId = id;
            Console.WriteLine("Employee added: " + name + " (ID: " + id + ")");
        }

        public void CheckAttendance()
        {
            Console.WriteLine("Choose work type:");
            Console.WriteLine("1. Part Time");
            Console.WriteLine("2. Full Time");
            Console.Write("Enter choice: ");

            int workType = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Random random = new Random();
            int attendance = random.Next(0, 2); // Random 0 or 1

            if (attendance == 0)
            {
                employee.IsPresent = 0;
                Console.WriteLine("Employee " + employee.EmployeeName + " is Absent (Random Check)");
            }
            else
            {
                switch (workType)
                {
                    case 1:
                        employee.IsPresent = 1;
                        Console.WriteLine("Employee " + employee.EmployeeName + " is Present - Part Time (Random Check)");
                        break;
                    case 2:
                        employee.IsPresent = 2;
                        Console.WriteLine("Employee " + employee.EmployeeName + " is Present - Full Time (Random Check)");
                        break;
                    default:
                        employee.IsPresent = 1;
                        Console.WriteLine("Invalid choice! Setting as Present - Part Time (Random Check)");
                        break;
                }
            }
        }

        public int CalculateDailyWage()
        {
            switch (employee.IsPresent)
            {
                case 0: // Absent
                    employee.DailyWage = 0;
                    break;
                case 1: // Part Time
                    employee.DailyWage = WagePerHour * PartTimeHour;
                    break;
                case 2: // Full Time
                    employee.DailyWage = WagePerHour * FullDayHour;
                    break;
                default:
                    employee.DailyWage = 0;
                    break;
            }
            return employee.DailyWage;
        }

        public int CalculateMonthlyWageWithCondition()
        {
            employee.TotalWorkingHours = 0;
            employee.TotalWorkingDays = 0;
            employee.MonthlyWage = 0;
            int presentDays = 0;
            
            Console.WriteLine("Choose work type:");
            Console.WriteLine("1. Part Time");
            Console.WriteLine("2. Full Time");
            Console.Write("Enter choice: ");
            
            int workType = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            Console.WriteLine("Calculating monthly attendance for " + DaysInMonth + " days...");
            Console.WriteLine("Conditions: Max " + WorkingDaysPerMonth + " working days OR " + MaxWorkingHours + " hours");
            Console.WriteLine();
            
            for (int day = 1; day <= DaysInMonth; day++)
            {
                Random random = new Random();
                int attendance = random.Next(0, 2); // 0=Absent, 1=Present
                
                Console.Write("Day " + day + ": ");
                
                if (attendance == 0)
                {
                    Console.WriteLine("Absent");
                }
                else
                {
                    presentDays++;
                    
                    switch (workType)
                    {
                        case 1: // Part Time
                            Console.WriteLine("Present - Part Time");
                            employee.TotalWorkingHours += PartTimeHour;
                            employee.MonthlyWage += WagePerHour * PartTimeHour;
                            break;
                        case 2: // Full Time
                            Console.WriteLine("Present - Full Time");
                            employee.TotalWorkingHours += FullDayHour;
                            employee.MonthlyWage += WagePerHour * FullDayHour;
                            break;
                        default:
                            Console.WriteLine("Present - Part Time (Default)");
                            employee.TotalWorkingHours += PartTimeHour;
                            employee.MonthlyWage += WagePerHour * PartTimeHour;
                            break;
                    }
                }
                
                if (employee.TotalWorkingHours >= MaxWorkingHours || presentDays >= WorkingDaysPerMonth)
                {
                    Console.WriteLine();
                    if (employee.TotalWorkingHours >= MaxWorkingHours)
                    {
                        Console.WriteLine("Maximum working hours (" + MaxWorkingHours + ") reached on day " + day + "!");
                    }
                    if (presentDays >= WorkingDaysPerMonth)
                    {
                        Console.WriteLine("Maximum working days (" + WorkingDaysPerMonth + ") reached on day " + day + "!");
                    }
                    break;
                }
            }
            
            employee.TotalWorkingDays = presentDays;
            
            Console.WriteLine();
            Console.WriteLine("Total present days: " + presentDays);
            Console.WriteLine("Total working hours: " + employee.TotalWorkingHours);
            
            return employee.MonthlyWage;
        }

        public void ProcessEmployee()
        {
            // get employee details from user
            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Employee ID: ");
            int id = int.Parse(Console.ReadLine());

            AddEmployee(name, id);
            Console.WriteLine();

            // calculate monthly wage with condition
            int monthlyWage = CalculateMonthlyWageWithCondition();
            Console.WriteLine("Monthly wage calculated: $" + monthlyWage);
            Console.WriteLine();

            // show employee info
            Console.WriteLine("Employee Details:");
            Console.WriteLine(employee.ToString());
        }
    }
}