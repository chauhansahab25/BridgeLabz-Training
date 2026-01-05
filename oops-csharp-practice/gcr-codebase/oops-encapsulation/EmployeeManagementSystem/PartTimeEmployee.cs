using System;

namespace CG_Practice.oopscsharp.EmployeeManagementSystem
{
    // part time employee class
    class PartTimeEmployee : Employee
    {
        private int hoursWorked;
        private double hourlyRate;

        public int HoursWorked { get { return hoursWorked; } set { hoursWorked = value; } }
        public double HourlyRate { get { return hourlyRate; } set { hourlyRate = value; } }

        public PartTimeEmployee(int id, string name, double salary, int hours, double rate) : base(id, name, salary)
        {
            hoursWorked = hours;
            hourlyRate = rate;
        }

        // salary based on hours worked
        public override double CalculateSalary()
        {
            return hoursWorked * hourlyRate;
        }
    }
}