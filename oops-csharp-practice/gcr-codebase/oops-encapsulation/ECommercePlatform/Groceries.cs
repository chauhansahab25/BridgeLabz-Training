using System;

namespace CG_Practice.oopscsharp.ECommercePlatform
{
    // groceries product class
    class Groceries : Product
    {
        private DateTime expiryDate;

        public DateTime ExpiryDate { get { return expiryDate; } set { expiryDate = value; } }

        public Groceries(int id, string name, double price, DateTime expiry) : base(id, name, price)
        {
            expiryDate = expiry;
        }

        public override double CalculateDiscount()
        {
            return Price * 0.05; // 5% discount on groceries
        }
    }
}