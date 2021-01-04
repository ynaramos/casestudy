using System.ComponentModel.DataAnnotations;

namespace GoldenShoe.ViewModels
{
    public class ShoppingCartItemViewModel 
    {
        public int ProductID { get; set; }

        public string ShoeName { get; set; }

        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [DataType(DataType.Currency)]
        public double DiscountedPrice { get; set; }

        [DataType(DataType.Currency)]
        public double TotalPrice { get; set; }

        [DataType(DataType.Currency)]
        public double DiscountedTotalPrice { get; set; }

        public string PhotoFilePath { get; set; }

        public int SizeID { get; set; }

        public double Size { get; set; }

        public int Quantity { get; set; }
    }
}
