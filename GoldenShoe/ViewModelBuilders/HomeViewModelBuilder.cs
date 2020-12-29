using DataAccess;
using DataAccess.DataModels;
using GoldenShoe.ViewModels;
using System.Collections.Generic;

namespace GoldenShoe.ViewModelBuilders
{
    public class HomeViewModelBuilder
    {
        private readonly Context _context;

        public HomeViewModelBuilder(Context context)
        {
            _context = context;
        }

        public HomeViewModel GetAllProductsForDisplay()
        {
            var repo = new DataRepository(_context);

            IList<Product> products = repo.GetAllProducts().Result;

            var model = new HomeViewModel
            {
                Products = products,
                InCart = new List<ShoppingCartItemViewModel>()
            };

            return model;
        }
    }
}
