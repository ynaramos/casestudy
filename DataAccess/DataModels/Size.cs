using System.Collections.Generic;

namespace DataAccess.DataModels
{
    public class Size
    {
        public int ID { get; set; }

        public double SizeNumber { get; set; }

        public ICollection<ProductAvailability> SizeAvailabilities { get; set; }

        public ICollection<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
