using DataAccess.DataModels;
using System.Collections.Generic;

namespace GoldenShoe.ViewModels
{
    public class ProductViewModel
    { 
        public Product Product { get; set; }

        public IList<ProductSizeAvailabilitiesViewModel> Availabilities { get; set; }

        public IList<ShoppingCartItemViewModel> InCart { get; set; }
    }
}
