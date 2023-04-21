using CSharp_MVC.Entity;
using CSharp_MVC.Models;
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
        Task<bool> CreateUserAccount(UserVm user, CustomerVm customer);
        //User GetByUserId(int voucherID);
    }
}
