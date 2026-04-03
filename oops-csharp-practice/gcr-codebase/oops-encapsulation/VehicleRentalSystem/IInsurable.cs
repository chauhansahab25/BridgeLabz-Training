using System;

namespace CG_Practice.oopscsharp.VehicleRentalSystem
{
    // interface for vehicles that can be insured
    interface IInsurable
    {
        double CalculateInsurance();
        string GetInsuranceDetails();
    }
}