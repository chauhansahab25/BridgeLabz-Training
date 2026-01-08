using System;

namespace CG_Practice.oopsscenario.EmployeeWageComputation
{
    // interface for employee operations
    interface IEmployee
    {
        void AddEmployee(string name, int id);
        void CheckAttendance();
        int CalculateDailyWage();
        int CalculateMonthlyWage();
    }
}