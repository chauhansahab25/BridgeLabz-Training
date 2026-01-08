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
            Random random = new Random();
            employee.IsPresent = random.Next(0, 2); // Random 0 or 1
            
            if (employee.IsPresent == 1)
            {
                Console.WriteLine("Employee " + employee.EmployeeName + " is Present (Random Check)");
            }
            else
            {
                Console.WriteLine("Employee " + employee.EmployeeName + " is Absent (Random Check)");
            }
        }

        public int CalculateDailyWage()
        {
            if (employee.IsPresent == 1)
            {
                employee.DailyWage = Employee.WagePerHour * Employee.FullDayHour;
                return employee.DailyWage;
            }
            employee.DailyWage = 0;
            return 0;
        }

        public void ProcessEmployee()
        {
            Console.WriteLine("=== Employee Wage Computation UC3 - Random Attendance ===");
            Console.WriteLine();

            // get employee details from user
            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();
            
            Console.Write("Enter Employee ID: ");
            int id = int.Parse(Console.ReadLine());
            
            AddEmployee(name, id);
            Console.WriteLine();

            // check random attendance
            CheckAttendance();
            Console.WriteLine();

            // calculate wage
            int wage = CalculateDailyWage();
            Console.WriteLine("Daily wage calculated: $" + wage);
            Console.WriteLine();

            // show employee info
            Console.WriteLine("Employee Details:");
            Console.WriteLine(employee.ToString());
        }
    }
}