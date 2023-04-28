using CSharp_MVC.Models;
using DataAccess;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Service;
using System.Diagnostics;

namespace CSharp_MVC.Controllers
{
    public class UHomeController : Controller
    {
        private readonly ILogger<UHomeController> _logger;
        private readonly ApplicationDbContext _db;
        private readonly IProductService _productService;
        private readonly IProductCategoryService _productCategoryService;

        public UHomeController(ILogger<UHomeController> logger, ApplicationDbContext db, IProductService productService, IProductCategoryService productCategoryService)
        {
            _logger = logger;
            _db = db;
            _productService = productService;
            _productCategoryService = productCategoryService;
        }

        public IActionResult Index()
        {
            var categories = _productCategoryService.GetAll();
            var products = _productService.GetAll().Select(p => new ProductVm
            {
                ProductID = p.ProductID,
                ProductName = p.ProductName,
                Price = p.Price,
                Picture = p.Picture,
                Quantity = p.Quantity,
                Description = p.Description,
                ProdCateID = p.ProdCateID
            });
            var viewModel = products.Join(
                categories,
                p => p.ProdCateID,
                c => c.ProdCateID,
                (p, c) => new ProductVm
                {
                    ProductID = p.ProductID,
                    ProductName = p.ProductName,
                    Price = p.Price,
                    Picture = p.Picture,
                    Quantity = p.Quantity,
                    Description = p.Description,
                    ProdCateID = p.ProdCateID,
                    ProdCateName = c.ProdCateName
                });
            return View(products);
        }

        public IActionResult Details()
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