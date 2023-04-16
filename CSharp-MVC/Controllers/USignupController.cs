using Microsoft.AspNetCore.Mvc;

namespace CSharp_MVC.Controllers
{
    public class SignupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
