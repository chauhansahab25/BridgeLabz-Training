using System;

namespace CG_Practice.oopscsharp.EmployeeManagementSystem
{
    // interface for department operations
    interface IDepartment
    {
        void AssignDepartment(string dept);
        string GetDepartmentDetails();
    }
}