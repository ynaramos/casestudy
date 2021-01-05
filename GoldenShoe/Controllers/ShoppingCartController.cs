using DataAccess;
using GoldenShoe.ViewModelActioners;
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

        [HttpGet]
        public IActionResult DisplayShoppingCartItems()
        {
            ModelState.Clear();

            var builder = new ShoppingCartViewModelBuilder(_context);

            var model = builder.CreateModel();

            return View(model);
        }

        [HttpGet]
        public IActionResult ApplyVoucher(string voucherId)
        {
            var actioner = new ShoppingCartViewModelActioner(_context);

            var successful = actioner.AddVoucher(voucherId);

            if (!successful)
            {
                return Json(new { success = false, message = "The voucher code " + voucherId + " is not valid." });
            }

            return RedirectToAction("DisplayShoppingCartItems");
        }

        [HttpGet]
        public IActionResult RemoveItem(int productId, int sizeId)
        {
            var actioner = new ShoppingCartViewModelActioner(_context);

            actioner.RemoveShoppingCartItem(productId, sizeId);

            return RedirectToAction("DisplayShoppingCartItems");
        }

    }
}
