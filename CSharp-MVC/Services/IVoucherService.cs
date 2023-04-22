using CSharp_MVC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IVoucherService
    {
        //thêm, sửa, xóa, get all, ...
        Task CreateAsync(Voucher voucher);
        Task DeleteAsync(Voucher voucher);

        Task UpdateAsync(Voucher voucher);
        Task DeleteById(int id);

        IEnumerable<Voucher> GetAll();
        Voucher GetByVoucherId(int voucherID);
    }
}
