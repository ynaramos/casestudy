using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.DataModels
{
    public class Product
    {
        public int ID { get; set; }

        public int? ColourId { get; set; }

        public string ShoeName { get; set; }

        [DataType(DataType.Currency)]
        public double Price { get; set; }

        public string PhotoFilepath { get; set; }

        public string Description { get; set; }

        public ICollection<ProductAvailability> ProductAvailabilities { get; set; }

        public Colour Colour { get; set; }
    }
}
