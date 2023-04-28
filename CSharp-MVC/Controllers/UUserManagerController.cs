using Microsoft.AspNetCore.Mvc;

namespace CSharp_MVC.Controllers
{
    public class UUserManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
