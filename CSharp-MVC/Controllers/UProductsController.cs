using CSharp_MVC.Models;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Service;
using Service.implementation;
using System.Drawing.Printing;

namespace CSharp_MVC.Controllers
{
    public class UProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly IProductCategoryService _procateCategoryService;
        private readonly IProductSaleService _productSaleService;
        public UProductsController(IProductService productService, IProductCategoryService procateCategoryService, IProductSaleService productSaleService)
        {
            _productService = productService;
            _procateCategoryService = procateCategoryService;
            _productSaleService = productSaleService;
        }
        [Route("products")]
        public IActionResult Index(int pageNumber = 1, int pageSize = 12)
        {

            var products = _productService.GetProducts(pageNumber, pageSize);

            var productcategory = _procateCategoryService.GetAllProduct();

            var productsale = _productSaleService.GetAllProductSale();

            var totalItems = _productService.GetTotalCount();

            var totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            var hasPreviousPage = (pageNumber > 1);

            var hasNextPage = (pageNumber < totalPages);
            var paginationViewModel = new StoreVm
            {
                Products = products.Result,
                Pagination = new Pagination
                {
                    CurrentPage = pageNumber,
                    PageSize = pageSize,
                    TotalItems = totalItems,
                    TotalPages = totalPages,
                    HasPreviousPage = hasPreviousPage,
                    HasNextPage = hasNextPage
                },
                ProductCategory = productcategory.Result,
                ProductSale = productsale.Result
            };
            return View(paginationViewModel);


        }
        [Route("products/category/{categoryId}")]
        public IActionResult Index(int categoryId, int pageNumber = 1, int pageSize = 12)
        {
            var products = _productService.GetProductsByCategory(categoryId, pageNumber, pageSize);

            var productcategory = _procateCategoryService.GetAllProduct();

            var productsale = _productSaleService.GetAllProductSale();

            int totalItems = _productService.GetTotalCount();

            var totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            var hasPreviousPage = (pageNumber > 1);

            var hasNextPage = (pageNumber < totalPages);

            var paginationViewModel = new StoreVm
            {
                Products = products.Result,
                Pagination = new Pagination
                {
                    CurrentPage = pageNumber,
                    PageSize = pageSize,
                    TotalItems = totalItems,
                    TotalPages = totalPages,
                    HasPreviousPage = hasPreviousPage,
                    HasNextPage = hasNextPage
                },
                ProductCategory = productcategory.Result,
                ProductSale = productsale.Result
            };
            return View(paginationViewModel);
        }
    }
}
