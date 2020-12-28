using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.DataModels
{
    public class ProductAvailability
    {
        public int ProductID { get; set; }

        public int SizeID { get; set; }

        public int NumberAvailable { get; set; }

        public Product Product { get; set; }

        public Size Size { get; set; }
    }
}
