using CSharp_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Service;
using System.Diagnostics;

namespace CSharp_MVC.Controllers
{
    public class UHomeController : Controller
    {
        private readonly IProductService _productService;
        private readonly IProductCategoryService _productCategoryService;


        private readonly ILogger<UHomeController> _logger;

        public UHomeController(ILogger<UHomeController> logger, IProductService productService, IProductCategoryService productCategoryService)
        {
            _productService = productService;
            _productCategoryService = productCategoryService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var listProduct = _productService.GetAll().Select(entity => new ProductVm {
                ProductID = entity.ProductID,
                ProductName = entity.ProductName,
                Description = entity.Description,
                Picture = entity.Picture,
                Price = (float)entity.Price,
                Quantity =(int) entity.Quantity,
            }).ToList();

            var listCategory = _productCategoryService.GetAll().Select(entity => new ProductCategoryVm
            {
               ProdCateID = entity.ProdCateID,
               ProdCateName = entity.ProdCateName,
            }).ToList();

            ViewBag.listProduct = listProduct;
            ViewBag.listCategory = listCategory;

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