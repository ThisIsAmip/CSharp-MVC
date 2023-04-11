using Microsoft.AspNetCore.Mvc;

namespace CSharp_MVC.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
