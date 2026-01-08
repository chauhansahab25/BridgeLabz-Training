using System;

namespace CG_Practice.oopsscenario.EmployeeWageComputation
{
    // employee interface - UC2
    interface IEmployee
    {
        void AddEmployee(string name, int id);
        void CheckAttendance();
        int CalculateDailyWage();
    }
}