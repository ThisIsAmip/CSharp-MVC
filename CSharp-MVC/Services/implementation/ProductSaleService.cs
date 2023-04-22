using CSharp_MVC.DataAccess;
using CSharp_MVC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.implementation
{
    public class ProductSaleService : IProductSaleService
    {
        private ApplicationDbContext _context;
        public ProductSaleService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(ProductSale productSale)
        {
            _context.ProductSale.Update(productSale);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(ProductSale productSale)
        {
            _context.ProductSale.Remove(productSale);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteById(int id)
        {

            var productSale = GetByProductSaleId(id);
            _context.ProductSale.Remove(productSale);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<ProductSale> GetAll()
        {
            foreach (var productSale in _context.ProductSale)
            {
                yield return productSale;
            }
        }
        public ProductSale GetByProductSaleId(int ProductSaleID)
        {
            return _context.ProductSale.Where(x => x.ProdSaleID == ProductSaleID).FirstOrDefault();
        }
        public async Task UpdateAsync(ProductSale ProductSale)
        {
            _context.ProductSale.Update(ProductSale);
            await _context.SaveChangesAsync();
        }
    }
}
