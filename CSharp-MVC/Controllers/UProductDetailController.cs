using CSharp_MVC.Models;
using DataAccess;
using Entity;
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
        private readonly IProductImageService _productImageService;

        public UProductDetailController(ILogger<UProductDetailController> logger, ApplicationDbContext db, IProductService productService, IProductCategoryService productCategoryService, IProductImageService productImageService)
        {
            _logger = logger;
            _db = db;
            _productService = productService;
            _productCategoryService = productCategoryService;
            _productImageService = productImageService;
        }

        public IActionResult Index(int id)
        {
            var product = _productService.GetByProductId(id);
            var category = _productCategoryService.GetByProductCategoryId(product.ProdCateID);
            var images = _productImageService.GetAllByID(id).Select(i => new ProductImageVm
            {
                ProductID = i.ProductID,
                Name = i.Name,
                ImageLink = i.ImageLink
            });
            ProductDetailVm productDetailVm = new ProductDetailVm();
            productDetailVm.ProductID = product.ProductID;
            productDetailVm.ProductName = product.ProductName;
            productDetailVm.Price = product.Price;
            productDetailVm.Picture = product.Picture;
            productDetailVm.Quantity = product.Quantity;
            productDetailVm.Description = product.Description;
            productDetailVm.ProdCateID = category.ProdCateID;
            productDetailVm.ProdCateName = category.ProdCateName;
            productDetailVm.Imgs = images.ToList();
            return View(productDetailVm);
        }


    }
}
