using System;

namespace CG_Practice.oopscsharp.HospitalPatientManagement
{
    // interface for medical record operations
    interface IMedicalRecord
    {
        void AddRecord(string record);
        void ViewRecords();
    }
}