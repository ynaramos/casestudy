using DataAccess;
using GoldenShoe.ViewModelActioners;
using GoldenShoe.ViewModelBuilders;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GoldenShoe.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private readonly Context _context;

        public ProductController(ILogger<ProductController> logger, Context context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult DisplayProductPage(int productId)
        {
            var builder = new ProductViewModelBuilder(_context);

            var model = builder.GetProductForDisplay(productId);

            return View(model);
        }

        public IActionResult AddProductToCart(int productId, int sizeId)
        {
            var actioner = new ProductViewModelActioner(_context);

            actioner.AddItemToCart(productId, sizeId);

            return RedirectToAction("DisplayProductPage", new { productId });
        }
    }
}
