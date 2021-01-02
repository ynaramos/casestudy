using DataAccess.DataModels;
using Microsoft.EntityFrameworkCore;
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

        public int GetShoppingCartQuantities()
        {
            return Context
                .Set<ShoppingCartItem>()
                .Sum(x => x.Quantity);
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
    }
}
