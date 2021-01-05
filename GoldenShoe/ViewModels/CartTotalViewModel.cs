using DataAccess.DataModels;
using System.ComponentModel.DataAnnotations;

namespace GoldenShoe.ViewModels
{
    public class CartTotalViewModel
    {
        public Voucher Voucher { get; set; }

        [DataType(DataType.Currency)]
        public double Total { get; set; }

        [DataType(DataType.Currency)]
        public double DiscountedTotal { get; set; }

        public bool VoucherApplied { get; set; }

        public bool CanCheckout { get; set; }
    }
}
