﻿using CSharp_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Service;
using System.Diagnostics;

namespace CSharp_MVC.Controllers
{
    public class UHomeController : Controller
    {
        private readonly IProductService _productService;


        private readonly ILogger<UHomeController> _logger;

        public UHomeController(ILogger<UHomeController> logger, IProductService productService)
        {
            _productService = productService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            Product product = new Product();
            product.ProductID = 1;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}