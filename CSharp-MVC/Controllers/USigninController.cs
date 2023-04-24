using CSharp_MVC.Models;
using CSharp_MVC.Request;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Service;
using Service.implementation;

namespace CSharp_MVC.Controllers
{
    public class USigninController : Controller
    {
        private readonly IUserService _userService;
        public USigninController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index([FromForm] UserRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }
            string Account = request.Account;
            string Password = request.Password;
            var user = _userService.GetByUserAccount(Account, Password);
            if (user == null)
            {
                ModelState.AddModelError("", "Sai tài khoản hoặc mật khẩu");
                return View();
            }
            var customerInformation = JsonConvert.SerializeObject(user);
            HttpContext.Session.SetString("customer", customerInformation);
            return RedirectToAction("Index","UHome");
        }
        [HttpPost("logout")]
        public IActionResult Signout()
        {
            HttpContext.Session.Remove("customer");
            return RedirectToAction("Index", "UHome");
        }
    }
}
