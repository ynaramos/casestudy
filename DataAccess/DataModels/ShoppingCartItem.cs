namespace DataAccess.DataModels
{
    public class ShoppingCartItem
    {
        public int ProductID { get; set; }

        public int SizeID { get; set; }

        public int Quantity { get; set; }

        public Product Product { get; set; }

        public Size Size { get; set; }
    }
}
