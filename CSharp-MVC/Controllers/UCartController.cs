using Microsoft.AspNetCore.Mvc;

namespace CSharp_MVC.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
