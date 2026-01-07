using System;

namespace CG_Practice.oopsscenario.EmployeeWageComputation
{
    // interface for employee wage operations
    interface IEmployeeWage
    {
        void CheckAttendance();
        int CalculateDailyWage(); // uc2 function
        int CalculateMonthlyWage(); // uc5 function
    }
}