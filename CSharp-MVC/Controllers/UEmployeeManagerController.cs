using Microsoft.AspNetCore.Mvc;

namespace CSharp_MVC.Controllers
{
    public class UEmployeeManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
