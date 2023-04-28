using Microsoft.AspNetCore.Mvc;

namespace CSharp_MVC.Controllers
{
    public class UManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
