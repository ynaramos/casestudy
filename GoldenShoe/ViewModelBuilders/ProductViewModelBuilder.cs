using DataAccess;
using GoldenShoe.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace GoldenShoe.ViewModelBuilders
{
    public class ProductViewModelBuilder
    {
        private readonly Context _context;

        public ProductViewModelBuilder(Context context)
        {
            _context = context;
        }

        public ProductViewModel GetProductForDisplay(int id)
        {
            var repo = new DataRepository(_context);

            var product = repo.GetProductForDisplay(id).Result;

            var sizesAvailable = repo.GetProductAvailabilitiesByProductId(id).Result;

            var sizes = new List<SelectListItem>();

            int numInCart = repo.GetShoppingCartQuantities();

            foreach (var sizeAvailable in sizesAvailable)
            {
                sizes.Add(new SelectListItem { 
                    Value = sizeAvailable.SizeID.ToString(), 
                    Text = sizeAvailable.NumberAvailable > 0 ? sizeAvailable.Size.SizeNumber.ToString() : sizeAvailable.Size.SizeNumber.ToString() + " (Unavailable)", 
                    Disabled = sizeAvailable.NumberAvailable <= 0
                });
            }

            var model = new ProductViewModel
            {
                Product = product,
                SelectedSizeID = 0,
                Availabilities = sizes,
                InCart = numInCart
            };

            return model;
        }
    }
}
