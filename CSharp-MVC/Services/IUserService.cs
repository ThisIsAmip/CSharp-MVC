using CSharp_MVC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IUserService
    {
        //thêm, sửa, xóa, get all, ...
        //Task CreateAsync(User user);
        //Task DeleteAsync(User user);

        //Task UpdateAsync(User user);
        //Task DeleteById(int id);

        //IEnumerable<User> GetAll();
        User GetByUserAccount(string Account, string Password);
        //User GetByUserId(int voucherID);
    }
}
