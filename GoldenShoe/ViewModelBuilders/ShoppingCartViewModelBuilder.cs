using DataAccess;
using DataAccess.DataModels;
using GoldenShoe.ViewModels;
using System.Linq;

namespace GoldenShoe.ViewModelBuilders
{
    public class ShoppingCartViewModelBuilder
    {
        private readonly Context _context;

        public ShoppingCartViewModelBuilder(Context context)
        {
            _context = context;
        }

        public ShoppingCartViewModel CreateModel(string? voucherId)
        {
            var repo = new DataRepository(_context);

            var shoppingCartItems = repo.GetAllItemsInCart().Result;

            var shoppingCartItemsVM = shoppingCartItems
                .Select(x => new ShoppingCartItemViewModel()
                {
                    ProductID = x.ProductID,
                    ShoeName = x.Product.ShoeName,
                    Price = x.Product.Price,
                    DiscountedPrice = 0,
                    TotalPrice = x.Product.Price * x.Quantity,
                    PhotoFilePath = x.Product.PhotoFilepath,
                    SizeID = x.SizeID,
                    Size = x.Size.SizeNumber,
                    Quantity = x.Quantity
                })
                .ToList();
            
            var numOfShoppingCartItems = repo.GetShoppingCartQuantities();

            var total = new CartTotalViewModel
            {
                Voucher = new Voucher(),
                Total = repo.GetShoppingCartTotal()
            };

            var model = new ShoppingCartViewModel()
            {
                ProductsInCart = shoppingCartItemsVM,
                CartPayment = total,
                InCart = numOfShoppingCartItems
            };

            return model;
        }
    }
}
