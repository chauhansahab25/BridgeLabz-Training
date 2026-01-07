using System;

namespace CG_Practice.oopsscenario.EmployeeWageComputation
{
    // interface for employee wage operations - UC1
    interface IEmployeeWage
    {
        void AddEmployee(string name, int id);
        void CheckAttendance();
    }
}