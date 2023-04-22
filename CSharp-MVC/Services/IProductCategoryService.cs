using CSharp_MVC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IProductCategoryService
    {
        //thêm, sửa, xóa, get all, ...
        Task CreateAsync(ProductCategory productCategory);
        Task DeleteAsync(ProductCategory productCategory);

        Task UpdateAsync(ProductCategory productCategory);
        Task DeleteById(int id);

        IEnumerable<ProductCategory> GetAll();
        ProductCategory GetByProductCategoryId(int productCategory);
    }
}
