﻿using Microsoft.AspNetCore.Mvc;

namespace CSharp_MVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
