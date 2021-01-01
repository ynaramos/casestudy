using DataAccess.DataModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace GoldenShoe.ViewModels
{
    public class ProductViewModel
    {
        public Product Product { get; set; }

        public int SelectedSizeID { get; set; }

        public IEnumerable<SelectListItem> Availabilities { get; set; }

        public int InCart { get; set; }
    }
}
