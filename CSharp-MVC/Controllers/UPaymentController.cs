using Microsoft.AspNetCore.Mvc;

namespace CSharp_MVC.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
