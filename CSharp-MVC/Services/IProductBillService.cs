using CSharp_MVC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IProductBillService
    {
        //thêm, sửa, xóa, get all, ...
        Task CreateAsync(ProductBill productBill);
        Task DeleteAsync(ProductBill productBill);

        Task UpdateAsync(ProductBill productBill);
        Task DeleteById(int productID, int billID);

        IEnumerable<ProductBill> GetAll();
        ProductBill GetByProductBillId(int productID, int billID);
    }
}
