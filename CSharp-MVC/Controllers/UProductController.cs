﻿using Microsoft.AspNetCore.Mvc;

namespace CSharp_MVC.Controllers
{
    public class UProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
