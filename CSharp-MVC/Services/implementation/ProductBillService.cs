using CSharp_MVC.DataAccess;
using CSharp_MVC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.implementation
{
    public class ProductBillService : IProductBillService
    {
        private ApplicationDbContext _context;
        public ProductBillService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(ProductBill procductBill)
        {
            _context.ProductBill.Update(procductBill);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(ProductBill procductBill)
        {
            _context.ProductBill.Remove(procductBill);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteById(int productID, int billID)
        {
            var productbillId = GetByProductBillId(productID, billID);
            _context.ProductBill.Remove((ProductBill)productbillId);
            await _context.SaveChangesAsync();
        }
        public IEnumerable<ProductBill> GetAll()
        {
            foreach (var item in _context.ProductBill)
            {
                yield return item;
            }
        }

        public ProductBill GetByProductBillId(int productID, int billID)
        {
            return _context.ProductBill.Where(x => x.ProductID == productID & x.BillID == billID).FirstOrDefault();
        }

        public async Task UpdateAsync(ProductBill item)
        {
            _context.ProductBill.Update(item);
            await _context.SaveChangesAsync();
        }
    }
}
