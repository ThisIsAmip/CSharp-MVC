using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.implementation
{
    public class ProductService : IProductService
    {
        private ApplicationDbContext _context;
        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Product product)
        {
            _context.Product.Update(product);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Product product)
        {
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteById(int id)
        {

            var product = GetByProductId(id);
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Product> GetAll()
        {
            foreach (var product in _context.Product)
            {
                yield return product;
            }
        }
        public Product GetByProductId(int productID)
        {
            return _context.Product.Where(x => x.ProductID == productID).FirstOrDefault();
        }
        public async Task UpdateAsync(Product product)
        {
            _context.Product.Update(product);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Product>> GetProducts(int pageNumber, int pageSize)
        {
            var products = _context.Product
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();
            return await Task.FromResult(products);
        }
        public async Task<List<Product>> GetProductsByCategory(int categoryId, int pageNumber, int pageSize)
        {
            var products = _context.Product.Where(x => x.ProdCateID == categoryId)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();
            return await Task.FromResult(products);
        }
        public int GetTotalCount()
        {
            return _context.Product.Count();
        }
    }
}
