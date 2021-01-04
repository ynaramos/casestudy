using System;

namespace DataAccess.DataModels
{
    public class Voucher
    {
        public string ID { get; set; }

        public int DiscountTypeID { get; set; }

        public DateTime? DiscountAvailableUntil { get; set; }

        public bool OneTimeUse { get; set; }

        public bool InUse { get; set; }

        public bool Used { get; set; }

        public DiscountType Discount { get; set; }
    }
}
