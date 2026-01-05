using System;

namespace CG_Practice.oopscsharp.OnlineFoodDeliverySystem
{
    // vegetarian food item class
    class VegItem : FoodItem, IDiscountable
    {
        private double discountApplied;

        public VegItem(string name, double price, int qty) : base(name, price, qty)
        {
            discountApplied = 0;
        }

        public override double CalculateTotalPrice()
        {
            double total = Price * Quantity;
            return total - discountApplied; // no extra charges for veg
        }

        public void ApplyDiscount(double percentage)
        {
            discountApplied = (Price * Quantity) * (percentage / 100);
            Console.WriteLine("Veg discount applied: " + percentage + "%");
        }

        public string GetDiscountDetails()
        {
            return "Veg item discount: $" + discountApplied;
        }
    }
}