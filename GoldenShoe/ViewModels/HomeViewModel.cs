using DataAccess.DataModels;
using System.Collections.Generic;

namespace GoldenShoe.ViewModels
{
    public class HomeViewModel
    {
        public IList<Product> Products { get; set; }
        
        public int InCart { get; set; }
    }
}
