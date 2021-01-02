using DataAccess.DataModels;
using System.Collections.Generic;

namespace GoldenShoe.ViewModels
{
    public class ShoppingCartViewModel
    {
        public IList<ShoppingCartItem> ProductsInCart { get; set; }

        public CartTotalViewModel CartPayment { get; set; }

        public int InCart { get; set; }
    }
}
