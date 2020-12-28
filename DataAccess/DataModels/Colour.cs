﻿using System.Collections.Generic;

namespace DataAccess.DataModels
{
    public class Colour
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
