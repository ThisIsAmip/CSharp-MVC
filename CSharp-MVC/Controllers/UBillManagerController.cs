using Microsoft.AspNetCore.Mvc;

namespace CSharp_MVC.Controllers
{
    public class UBillManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
