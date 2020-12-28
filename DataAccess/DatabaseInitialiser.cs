using DataAccess.DataModels;
using System;
using System.Linq;

namespace DataAccess
{
    public static class DatabaseInitialiser
    {
        public static void Initialise(Context context)
        {
            context.Database.EnsureCreated();

            if (context.DiscountTypes.Any()) { return; }

            /*--------------- ADD DISCOUNT TYPES ---------------*/
            var discountTypes = new DiscountType[]
            {
                new DiscountType { ID = 1, Description = "£10 off your purchase", IsPercentage = true, DiscountValue = 10, Threshold = null },
                new DiscountType { ID = 2, Description = "10% off your purchase", IsPercentage = false, DiscountValue = 10, Threshold = null },
                new DiscountType { ID = 3, Description = "£10 off orders above £50", IsPercentage= true, DiscountValue = 10, Threshold = 50 },
                new DiscountType { ID = 4, Description = "20% off your purchase", IsPercentage = false, DiscountValue = 20, Threshold = null }
            };

            foreach (DiscountType dt in discountTypes)
            {
                context.DiscountTypes.Add(dt);
            }
            context.Commit();

            /*--------------- ADD DISCOUNT TYPES ---------------*/
            var vouchers = new Voucher[]
            {
                new Voucher { ID = "£10OFFPLEASE", DiscountTypeID = 1, DiscountAvailableUntil = null, OneTimeUse = false },
                new Voucher { ID = "ABCDEFG", DiscountTypeID = 1, DiscountAvailableUntil = null, OneTimeUse = true },
                new Voucher { ID = "10%OFF", DiscountTypeID = 2, DiscountAvailableUntil = null, OneTimeUse = false },
                new Voucher { ID = "£10OFF", DiscountTypeID = 1, DiscountAvailableUntil = new DateTime(2015, 5, 30), OneTimeUse = false }
            };
        }
    }
}
