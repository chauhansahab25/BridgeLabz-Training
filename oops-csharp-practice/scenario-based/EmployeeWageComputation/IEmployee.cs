using System;

namespace CG_Practice.oopsscenario.EmployeeWageComputation
{
    // interface for employee operations
    interface IEmployee
    {
        void AddEmployee();
        void CheckAttendance();
        int CalculateDailyWage();
    }
}
