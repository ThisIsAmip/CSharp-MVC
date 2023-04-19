using CSharp_MVC.DataAccess;
using CSharp_MVC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.implementation
{
    public class ProductCategoryService : IProductCategoryService
    {
        private ApplicationDbContext _context;
        public ProductCategoryService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(ProductCategory productCategory)
        {
            _context.ProductCategory.Update(productCategory);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(ProductCategory productCategory)
        {
            _context.ProductCategory.Remove(productCategory);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteById(int id)
        {

            var productCategory = GetByProductCategoryId(id);
            _context.ProductCategory.Remove(productCategory);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<ProductCategory> GetAll()
        {
            foreach (var productCategory in _context.ProductCategory)
            {
                yield return productCategory;
            }
        }
        public ProductCategory GetByProductCategoryId(int productCategoryID)
        {
            return _context.ProductCategory.Where(x => x.ProdCateID == productCategoryID).FirstOrDefault();
        }
        public async Task UpdateAsync(ProductCategory productCategory)
        {
            _context.ProductCategory.Update(productCategory);
            await _context.SaveChangesAsync();
        }
    }
}
