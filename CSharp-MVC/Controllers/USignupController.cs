using CSharp_MVC.Models;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace CSharp_MVC.Controllers
{
    public class USignupController : Controller
    {
        private readonly IUserService _userService;
        public USignupController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var session = HttpContext.Session.GetString("customer");
            if (session != null)
            {
                return RedirectToAction("Index", "UHome");
            }

            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            return View();  
        }
        [HttpPost]
        public async Task<IActionResult> Index(Signup user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }
            var newuser = new User()
            {
                Account = user.Account,
                Password = user.Password
            };
            var newcustomer = new Customer()
            {
                FullName = user.FullName,
                Nationality = user.Nationality,
                Phone = user.Phone,
                Address= user.Address,
                Email = user.Email
            };
            var result = await _userService.CreateUserAccount(newuser, newcustomer);
            if (result == false)
            {
                ModelState.AddModelError("", "Account already existed !");
                return View();
            }
            TempData["result"] = "Sign up successfully !";
            return RedirectToAction("Index", "USignup");

        }
    }
}
