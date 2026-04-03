using System;

namespace CG_Practice.oopscsharp.ECommercePlatform
{
    // clothing product class
    class Clothing : Product, ITaxable
    {
        private string size;

        public string Size { get { return size; } set { size = value; } }

        public Clothing(int id, string name, double price, string clothSize) : base(id, name, price)
        {
            size = clothSize;
        }

        public override double CalculateDiscount()
        {
            return Price * 0.15; // 15% discount on clothing
        }

        public double CalculateTax()
        {
            return Price * 0.12; // 12% GST
        }

        public string GetTaxDetails()
        {
            return "GST 12% applied";
        }
    }
}