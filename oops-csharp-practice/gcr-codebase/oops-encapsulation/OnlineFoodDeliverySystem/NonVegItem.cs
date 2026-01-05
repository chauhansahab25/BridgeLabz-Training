using System;

namespace CG_Practice.oopscsharp.OnlineFoodDeliverySystem
{
    // non-vegetarian food item class
    class NonVegItem : FoodItem, IDiscountable
    {
        private double extraCharge;
        private double discountApplied;

        public NonVegItem(string name, double price, int qty) : base(name, price, qty)
        {
            extraCharge = 50; // extra charge for non-veg
            discountApplied = 0;
        }

        public override double CalculateTotalPrice()
        {
            double total = (Price * Quantity) + extraCharge;
            return total - discountApplied;
        }

        public void ApplyDiscount(double percentage)
        {
            discountApplied = (Price * Quantity) * (percentage / 100);
            Console.WriteLine("Non-veg discount applied: " + percentage + "%");
        }

        public string GetDiscountDetails()
        {
            return "Non-veg item discount: $" + discountApplied + " (Extra charge: $" + extraCharge + ")";
        }
    }
}