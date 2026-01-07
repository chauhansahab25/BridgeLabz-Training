using System;

namespace CG_Practice.oopsscenario.EmployeeWageComputation
{
    // interface for employee wage operations
    interface IEmployeeWage
    {
        void AddEmployee(string name, int id);
        void CheckAttendance();
        int CalculateDailyWage();
        int CalculateMonthlyWage();
        void CalculateWageTillCondition();
    }
}