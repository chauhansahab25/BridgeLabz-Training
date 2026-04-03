using System;

namespace CG_Practice.oopscsharp.EmployeeManagementSystem
{
    // full time employee class
    class FullTimeEmployee : Employee
    {
        private double bonus;

        public double Bonus { get { return bonus; } set { bonus = value; } }

        public FullTimeEmployee(int id, string name, double salary, double empBonus) : base(id, name, salary)
        {
            bonus = empBonus;
        }

        // fixed salary calculation for full time
        public override double CalculateSalary()
        {
            return BaseSalary + bonus;
        }
    }
}