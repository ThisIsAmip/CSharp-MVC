using CSharp_MVC.DataAccess;
using CSharp_MVC.Entity;
using CSharp_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Service.implementation
{
    public class UserService : IUserService
    {
        private ApplicationDbContext _context;
        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateAsync(User user)
        {
            var checkUser = _context.TaiKhoan.Where(x => x.Account == user.Account).FirstOrDefault();
            if (checkUser != null)
            {
                return false;
            }
            var newUser = new User();
            newUser.Account = user.Account;
            newUser.Password = user.Password;
            newUser.UserID = user.UserID;
            newUser.RoleId = 1;
            _context.TaiKhoan.Add(newUser);
            return await _context.SaveChangesAsync() > 0;
        }
        //public async Task DeleteAsync(User user)
        //{
        //    _context.TaiKhoan.Remove(user);
        //    await _context.SaveChangesAsync();
        //}
        //public async Task DeleteById(int id)
        //{
        //    var user = GetByUserId(id);
        //    _context.TaiKhoan.Remove(user);
        //    await _context.SaveChangesAsync();
        //}

        //public IEnumerable<Entity.User> GetAll()
        //{
        //    foreach (var user in _context.TaiKhoan)
        //    {
        //        yield return user;
        //    }
        //}

        public User GetByUserAccount(string Account, string Password)
        {
            return _context.TaiKhoan.Where(x => x.Account == Account && x.Password == Password).FirstOrDefault();
        }
        public async Task<bool> CreateUserAccount(UserVm user, CustomerVm customer)
        {
            var check = _context.TaiKhoan.Where(x => x.Account == user.Account).FirstOrDefault();
            if (check != null)
            {
                return false;
            }

            var newuser1 = new User();
            var newuser2 = new Customer();
            newuser1.Account = user.Account;
            newuser1.Password = user.Password;
            _context.TaiKhoan.Add(newuser1);

            newuser2.Account = user.Account;
            newuser2.FullName = customer.FullName;
            _context.Customer.Add(newuser2);
            return await _context.SaveChangesAsync() > 0;


        }
        //public User GetByUserId(int UserId)
        //{
        //    return _context.TaiKhoan.Where(x => x.UserID == UserId).FirstOrDefault();
        //}

        //public async Task UpdateAsync(User user)
        //{
        //    _context.TaiKhoan.Update(user);
        //    await _context.SaveChangesAsync();
        //}
    }
}
