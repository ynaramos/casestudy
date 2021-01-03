using DataAccess;
using GoldenShoe.ViewModelBuilders;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GoldenShoe.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly Context _context;
        private readonly ILogger<ShoppingCartController> _logger;

        public ShoppingCartController(ILogger<ShoppingCartController> logger, Context context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult DisplayShoppingCartItems()
        {
            var builder = new ShoppingCartViewModelBuilder(_context);

            var model = builder.CreateModel("");

            return View(model);
        }
    }
}
