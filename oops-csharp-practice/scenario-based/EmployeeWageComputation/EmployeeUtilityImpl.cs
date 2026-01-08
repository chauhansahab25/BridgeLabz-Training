using System;

namespace CG_Practice.oopsscenario.EmployeeWageComputation
{
    // utility class for employee operations
    class EmployeeUtilityImpl
    {
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
                    employee.DailyWage = Employee.WagePerHour * Employee.PartTimeHour;
                    break;
                case 2: // Full Time
                    employee.DailyWage = Employee.WagePerHour * Employee.FullDayHour;
                    break;
                default:
                    employee.DailyWage = 0;
                    break;
            }
            return employee.DailyWage;
        }

        public void ProcessEmployee()
        {
            Console.WriteLine("=== Employee Wage Computation UC4===");
            Console.WriteLine();

            // get employee details from user
            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Employee ID: ");
            int id = int.Parse(Console.ReadLine());

            AddEmployee(name, id);
            Console.WriteLine();


            CheckAttendance();
            Console.WriteLine();


            int wage = CalculateDailyWage();
            Console.WriteLine("Daily wage calculated: $" + wage);
            Console.WriteLine();


            Console.WriteLine("Employee Details:");
            Console.WriteLine(employee.ToString());
        }
    }
}