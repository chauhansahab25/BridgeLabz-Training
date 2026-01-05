using System;

namespace CG_Practice.oopscsharp.ECommercePlatform
{
    // interface for products that have tax
    interface ITaxable
    {
        double CalculateTax();
        string GetTaxDetails();
    }
}