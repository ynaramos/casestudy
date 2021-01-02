using DataAccess;

namespace GoldenShoe.ViewModelActioners
{
    public class ProductViewModelActioner
    {
        private readonly Context _context;

        public ProductViewModelActioner(Context context)
        {
            _context = context;
        }

        public void AddItemToCart(int productId, int sizeId)
        {
            var repo = new DataRepository(_context);
           
            if (repo.ShoppingCartItemExists(productId, sizeId))
            {
                repo.IncreaseItemQuantityInCart(productId, sizeId);
            }
            else
            {
                repo.AddItemInShoppingCart(productId, sizeId);
            }
        }
    }
}
