using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Service;

namespace CSharp_MVC.Controllers
{
    public class UCartController : Controller
    {
        private readonly ILogger<UCartController> _logger;
        private readonly ApplicationDbContext _db;
        private readonly IProductService _productService;
        private readonly ICustomerService _customerService;

        public UCartController(ILogger<UCartController> logger, ApplicationDbContext db, IProductService productService, ICustomerService customerService)
        {
            _logger = logger;
            _db = db;
            _productService = productService;
            _customerService = customerService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult AddToCart(int productId, int customerId)
        {
            var cartItem = new ShoppingCartItem { ProductId = productId, CustomerId = customerId };
            _db.ShoppingCartItems.Add(cartItem);
            _db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult RemoveFromCart(int productId, int customerId)
        {
            var cartItem = _db.ShoppingCartItems.SingleOrDefault(c => c.ProductId == productId && c.CustomerId == customerId);
            if (cartItem != null)
            {
                _db.ShoppingCartItems.Remove(cartItem);
                _db.SaveChanges();
            }
            return RedirectToAction("Cart", "Home");
        }
    }
}
