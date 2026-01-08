using System;

namespace CG_Practice.oopsscenario.EmployeeWageComputation
{
    // employee interface
    interface IEmployee
    {
        void AddEmployee(string name, int id);
        void CheckAttendance();
    }
}