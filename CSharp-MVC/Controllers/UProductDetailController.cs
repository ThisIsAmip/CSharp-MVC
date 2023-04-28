using CSharp_MVC.Models;
using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace CSharp_MVC.Controllers
{
    public class UProductDetailController : Controller
    {
        private readonly ILogger<UProductDetailController> _logger;
        private readonly ApplicationDbContext _db;

        private readonly IProductService _productService;
        private readonly IProductCategoryService _productCategoryService;

        public UProductDetailController(ILogger<UProductDetailController> logger, ApplicationDbContext db, IProductService productService, IProductCategoryService productCategoryService)
        {
            _logger = logger;
            _db = db;
            _productService = productService;
            _productCategoryService = productCategoryService;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Index(int id)
        {
            var product = _productService.GetByProductId(id);
            var category = _productCategoryService.GetByProductCategoryId(product.ProdCateID);
            ProductVm productVm = new ProductVm();
            productVm.ProductID = product.ProductID;
            productVm.ProductName = product.ProductName;
            productVm.Price = product.Price;
            productVm.Picture = product.Picture;
            productVm.Quantity = product.Quantity;
            productVm.Description = product.Description;
            productVm.ProdCateID = product.ProdCateID;
            productVm.ProdCateName = category.ProdCateName;
            return View(productVm);
        }


    }
}
