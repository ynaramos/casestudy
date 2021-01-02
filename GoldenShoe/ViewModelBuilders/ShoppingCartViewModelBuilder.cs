using DataAccess;
using DataAccess.DataModels;
using GoldenShoe.ViewModels;

namespace GoldenShoe.ViewModelBuilders
{
    public class ShoppingCartViewModelBuilder
    {
        private readonly Context _context;

        public ShoppingCartViewModelBuilder(Context context)
        {
            _context = context;
        }

        public ShoppingCartViewModel CreateModel()
        {
            var repo = new DataRepository(_context);

            var shoppingCartItems = repo.GetAllItemsInCart().Result;

            var numOfShoppingCartItems = repo.GetShoppingCartQuantities();

            var total = new CartTotalViewModel
            {
                Voucher = new Voucher(),
                Total = repo.GetShoppingCartTotal()
            };

            var model = new ShoppingCartViewModel()
            {
                ProductsInCart = shoppingCartItems,
                CartPayment = total,
                InCart = numOfShoppingCartItems
            };

            return model;
        }
    }
}
