using CSharp_MVC.DataAccess;
using CSharp_MVC.Entity;
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
        //public async Task CreateAsync(User user)
        //{
        //    _context.TaiKhoan.Update(user);
        //    await _context.SaveChangesAsync();
        //}
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
