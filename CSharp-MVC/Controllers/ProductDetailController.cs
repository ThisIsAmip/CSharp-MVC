using Microsoft.AspNetCore.Mvc;

namespace CSharp_MVC.Controllers
{
    public class ProductDetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
