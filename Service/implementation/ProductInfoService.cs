using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.implementation
{
    public class ProductInfoService : IProductInfoService
    {
        private ApplicationDbContext _context;
        public ProductInfoService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task CreateAsync(ProductInfo productInfo)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(ProductInfo productInfo)
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductInfo> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetByUserId(int productInfo)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ProductInfo productInfo)
        {
            throw new NotImplementedException();
        }
    }
}
