using CSharp_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace CSharp_MVC.Controllers
{
    public class USignupController : Controller
    {
        private readonly IUserService _userService;
        private readonly ICustomerService _customerService;
        public USignupController(IUserService userService, ICustomerService customerService)
        {
            _userService = userService;
            _customerService = customerService;
        }
        public IActionResult Index()
        {

            return View();
        }
        public async Task<IActionResult> Index(UserVm user, CustomerVm customer)
        {
            if (ModelState.IsValid)
            {
                return View(user);  
            }
            var result = _userService.CreateUserAccount(user,customer);
            return View();  

        }
    }
}
