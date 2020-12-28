using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.DataModels
{
    public class DiscountType
    {
        public int ID { get; set; }

        public string Description { get; set; }

        public bool IsPercentage { get; set; }

        public double DiscountValue { get; set; }

        public double? Threshold { get; set; }

        public ICollection<Voucher> Vouchers { get; set; }
    }
}
