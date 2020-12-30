using DataAccess;
using GoldenShoe.ViewModels;
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

            var sizes = new List<ProductSizeAvailabilitiesViewModel>();

            foreach (var sizeAvailable in sizesAvailable)
            {
                sizes.Add(new ProductSizeAvailabilitiesViewModel { SizeID = sizeAvailable.SizeID, Size = sizeAvailable.Size.SizeNumber, Quantity = sizeAvailable.NumberAvailable });
            }

            var model = new ProductViewModel
            {
                Product = product,
                Availabilities = sizes,
                InCart = new List<ShoppingCartItemViewModel>()
            };

            return model;
        }
    }
}
