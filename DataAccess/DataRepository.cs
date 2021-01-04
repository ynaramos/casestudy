using DataAccess.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataRepository
    {
        private readonly Context Context;

        public DataRepository(Context context) 
        {
            Context = context;
        }

        public void AddItemInShoppingCart(int productId, int sizeId)
        {
            var newItem = new ShoppingCartItem
            {
                ProductID = productId,
                SizeID = sizeId,
                Quantity = 1
            };

            Context.AddEntity(newItem);
            Context.Commit();
        }

        public async Task<IList<Product>> GetAllProducts()
        {
            return await Context
                .Get<Product>()
                .OrderBy(x => x.ID)
                .ToListAsync();
        }

        public async Task<IList<ProductAvailability>> GetProductAvailabilitiesByProductId(int productId)
        {
            return await Context
                .Get<ProductAvailability>()
                .Where(x => x.ProductID == productId)
                .Include(x => x.Size)
                .OrderBy(x => x.Size.SizeNumber)
                .ToListAsync();
        }

        public async Task<Product> GetProductForDisplay(int productId)
        {
            return await Context
                .Get<Product>()
                .SingleAsync(x => x.ID == productId);
        }

        public async Task<IList<ShoppingCartItem>> GetAllItemsInCart()
        {
            return await Context
                .Set<ShoppingCartItem>()
                .Include(x => x.Product)
                .Include(x => x.Size)
                .ToListAsync();
        }

        public int GetShoppingCartQuantities()
        {
            return Context
                .Set<ShoppingCartItem>()
                .Sum(x => x.Quantity);
        }

        public double GetShoppingCartTotal()
        {
            return Context
                .Set<ShoppingCartItem>()
                .Sum(x => x.Product.Price * x.Quantity);
        }

        public async Task<Voucher> GetActiveVoucher()
        {
            return await Context
                .Get<Voucher>()
                .Include(x => x.Discount)
                .SingleAsync(x => x.InUse);
        }

        public async Task<Voucher> GetVoucher(string voucherCode)
        {
            return await Context
                .Get<Voucher>()
                .Include(x => x.Discount)
                .SingleAsync(x => x.ID == voucherCode);
        }

        public void IncreaseItemQuantityInCart(int productId, int sizeId)
        {
            var item = Context
                .Get<ShoppingCartItem>()
                .Single(x => x.ProductID == productId && x.SizeID == sizeId);

            item.Quantity += 1;

            Context.UpdateEntity(item);
            Context.Commit();
        }

        public bool ShoppingCartItemExists(int productId, int sizeId)
        {
            return Context
                .Get<ShoppingCartItem>()
                .Any(x => x.ProductID == productId && x.SizeID == sizeId);
        }

        public void SwitchOffVoucher()
        {
            var voucher = Context
                .Get<Voucher>()
                .Single(x => x.InUse);

            voucher.InUse = false;

            Context.UpdateEntity(voucher);
            Context.Commit();
        }

        public void UseVoucher(string voucherId)
        {
            var voucher = Context
                .Get<Voucher>()
                .Single(x => x.ID == voucherId);

            voucher.InUse = true;

            Context.UpdateEntity(voucher);
            Context.Commit();
        }

        public bool VoucherExists(string voucherId)
        {
            return Context
                .Get<Voucher>()
                .Any(x => x.ID == voucherId);
        }

        public bool VoucherInUseExists()
        {
            return Context
                .Get<Voucher>()
                .Any(x => x.InUse);
        }
    }
}
