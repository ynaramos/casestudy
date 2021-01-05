using DataAccess;
using DataAccess.DataModels;
using GoldenShoe.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace GoldenShoe.ViewModelBuilders
{
    public class ShoppingCartViewModelBuilder
    {
        private readonly Context _context;

        private const bool PERCENTAGE = true;

        private const bool FLAT = false;
        
        public ShoppingCartViewModelBuilder(Context context)
        {
            _context = context;
        }

        public ShoppingCartViewModel CreateModel()
        {
            var repo = new DataRepository(_context);
            var model = new ShoppingCartViewModel();

            if (repo.VoucherInUseExists())
            {
                model = ActiveVoucher(repo);
            }
            else
            {
                model = NoActiveVoucher(repo);
            }

            return model;
        }

        public ShoppingCartViewModel NoActiveVoucher(DataRepository repo)
        {
            var shoppingCartItems = repo.GetAllItemsInCart().Result;

            var shoppingCartItemsVM = shoppingCartItems
                .Select(x => new ShoppingCartItemViewModel()
                {
                    ProductID = x.ProductID,
                    ShoeName = x.Product.ShoeName,
                    Price = x.Product.Price,
                    DiscountedPrice = 0,
                    TotalPrice = x.Product.Price * x.Quantity,
                    DiscountedTotalPrice = 0,
                    PhotoFilePath = x.Product.PhotoFilepath,
                    SizeID = x.SizeID,
                    Size = x.Size.SizeNumber,
                    Quantity = x.Quantity,
                    Available = repo.ItemStillAvailable(x.ProductID, x.SizeID)
                })
                .ToList();

            var numOfShoppingCartItems = repo.GetShoppingCartQuantities();

            var total = new CartTotalViewModel
            {
                Voucher = new Voucher(),
                Total = repo.GetShoppingCartTotal(),
                VoucherApplied = false,
                CanCheckout = !shoppingCartItemsVM.Any(x => x.Available == false) && shoppingCartItemsVM.Count > 0
            };

            var model = new ShoppingCartViewModel()
            {
                ProductsInCart = shoppingCartItemsVM,
                CartPayment = total,
                InCart = numOfShoppingCartItems
            };

            return model;
        }

        public ShoppingCartViewModel ActiveVoucher(DataRepository repo)
        {
            var shoppingCartItems = repo.GetAllItemsInCart().Result;
            var shoppingCartItemsVM = new List<ShoppingCartItemViewModel>();
            var totalOfCart = repo.GetShoppingCartTotal();
            var totalDiscounted = repo.GetShoppingCartTotal();
            var voucher = repo.GetActiveVoucher().Result;


            if (voucher.Discount.IsPercentage == PERCENTAGE)
            {
                var discount = 1 - (voucher.Discount.DiscountValue / 100.0);

                shoppingCartItemsVM = shoppingCartItems
                .Select(x => new ShoppingCartItemViewModel()
                {
                    ProductID = x.ProductID,
                    ShoeName = x.Product.ShoeName,
                    Price = x.Product.Price,
                    DiscountedPrice = x.Product.Price * discount,
                    TotalPrice = x.Product.Price * x.Quantity,
                    DiscountedTotalPrice = (x.Product.Price * discount) * x.Quantity,
                    PhotoFilePath = x.Product.PhotoFilepath,
                    SizeID = x.SizeID,
                    Size = x.Size.SizeNumber,
                    Quantity = x.Quantity,
                    Available = repo.ItemStillAvailable(x.ProductID, x.SizeID)
                })
                .ToList();

                totalDiscounted *= discount;
            }
            else
            {
                shoppingCartItemsVM = shoppingCartItems
                .Select(x => new ShoppingCartItemViewModel()
                {
                    ProductID = x.ProductID,
                    ShoeName = x.Product.ShoeName,
                    Price = x.Product.Price,
                    DiscountedPrice = 0,
                    TotalPrice = x.Product.Price * x.Quantity,
                    DiscountedTotalPrice = 0,
                    PhotoFilePath = x.Product.PhotoFilepath,
                    SizeID = x.SizeID,
                    Size = x.Size.SizeNumber,
                    Quantity = x.Quantity,
                    Available = repo.ItemStillAvailable(x.ProductID, x.SizeID)
                })
                .ToList();

                totalDiscounted -= voucher.Discount.DiscountValue;
            }

            var numOfShoppingCartItems = repo.GetShoppingCartQuantities();

            var total = new CartTotalViewModel
            {
                Voucher = voucher,
                Total = totalOfCart,
                DiscountedTotal = totalDiscounted,
                VoucherApplied = true,
                CanCheckout = !shoppingCartItemsVM.Any(x => x.Available == false) && shoppingCartItemsVM.Count > 0
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
