using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IProductSaleService
    {
        //thêm, sửa, xóa, get all, ...
        Task CreateAsync(ProductSale productSale);
        Task DeleteAsync(ProductSale productSale);

        Task UpdateAsync(ProductSale productSale);
        Task DeleteById(int id);

        IEnumerable<ProductSale> GetAll();
        Task<List<ProductSale>> GetAllProductSale();
        ProductSale GetByProductSaleId(int productSale);
    }
}
