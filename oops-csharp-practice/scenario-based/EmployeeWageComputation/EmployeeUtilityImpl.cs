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

        public void ProcessEmployee()
        {
            Console.WriteLine("=== Employee Wage Computation UC3 - Random Attendance ===");
            Console.WriteLine();

            // get employee details from user
            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();
            
            Console.Write("Enter Employee ID: ");
            int id = int.Parse(Console.ReadLine());
            
            employee.AddEmployee(name, id);
            Console.WriteLine();

            // check random attendance
            employee.CheckAttendance();
            Console.WriteLine();

            // calculate wage
            int wage = employee.CalculateDailyWage();
            Console.WriteLine("Daily wage calculated: $" + wage);
            Console.WriteLine();

            // show employee info
            Console.WriteLine("Employee Details:");
            Console.WriteLine(employee.ToString());
        }
    }
}