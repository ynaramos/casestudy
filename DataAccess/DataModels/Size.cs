using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.DataModels
{
    public class Size
    {
        public int ID { get; set; }

        public double SizeNumber { get; set; }

        public ICollection<ProductAvailability> SizeAvailabilities { get; set; }
    }
}
