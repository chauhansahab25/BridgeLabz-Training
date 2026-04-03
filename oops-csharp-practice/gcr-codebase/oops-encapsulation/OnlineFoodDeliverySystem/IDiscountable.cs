using System;

namespace CG_Practice.oopscsharp.OnlineFoodDeliverySystem
{
    // interface for items that can have discounts
    interface IDiscountable
    {
        void ApplyDiscount(double percentage);
        string GetDiscountDetails();
    }
}