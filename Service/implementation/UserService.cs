using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task CreateAsync(User user)
        {
            _context.TaiKhoan.Update(user);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(User user)
        {
            _context.TaiKhoan.Remove(user);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteById(int id)
        {

            var user = GetByUserId(id);
            _context.TaiKhoan.Remove(user);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Entity.User> GetAll()
        {
            foreach (var user in _context.TaiKhoan)
            {
                yield return user;
            }
        }

        public User GetByUserId(int userID)
        {
            return _context.TaiKhoan.Where(x => x.UserID == userID).FirstOrDefault();
        }

        public async Task UpdateAsync(User user)
        {
            _context.TaiKhoan.Update(user);
            await _context.SaveChangesAsync();
        }
    }
}
