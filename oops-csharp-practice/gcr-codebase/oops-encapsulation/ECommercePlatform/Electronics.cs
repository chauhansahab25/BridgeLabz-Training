using System;

namespace CG_Practice.oopscsharp.ECommercePlatform
{
    // electronics product class
    class Electronics : Product, ITaxable
    {
        private int warranty;

        public int Warranty { get { return warranty; } set { warranty = value; } }

        public Electronics(int id, string name, double price, int warrantyMonths) : base(id, name, price)
        {
            warranty = warrantyMonths;
        }

        public override double CalculateDiscount()
        {
            return Price * 0.10; // 10% discount on electronics
        }

        public double CalculateTax()
        {
            return Price * 0.18; // 18% GST
        }

        public string GetTaxDetails()
        {
            return "GST 18% applied";
        }
    }
}