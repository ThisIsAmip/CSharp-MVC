using Microsoft.AspNetCore.Mvc;

namespace CSharp_MVC.Controllers
{
    public class UProductManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
