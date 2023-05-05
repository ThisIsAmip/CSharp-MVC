using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IProductService
    {
        //thêm, sửa, xóa, get all, ...
        Task<string> CreateAsync(Product product);
        Task<string> DeleteAsync(Product product);

        Task<string> UpdateAsync(Product product);
        Task<string> DeleteById(int id);

        IEnumerable<Product> GetAll();
        Product GetByProductId(int product);
        Product GetByProductName(string name);
        int GetCount();

        IEnumerable<Product> searchProduct(string name);
    }
}
