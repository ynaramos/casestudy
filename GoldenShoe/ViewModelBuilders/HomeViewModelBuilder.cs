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
            int numInCart = repo.GetShoppingCartQuantities();

            var model = new HomeViewModel
            {
                Products = products,
                InCart = numInCart
            };

            return model;
        }
    }
}
