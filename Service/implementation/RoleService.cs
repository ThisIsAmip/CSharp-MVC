using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.implementation
{
    public class RoleService : IRoleService
    {
        private ApplicationDbContext _context;

        public RoleService (ApplicationDbContext context)
        {
            _context = context;
        }

        public Task CreateAsSycn(Role role)
        {
            throw new NotImplementedException();
        }

        public async Task CreateAsync(Role role)
        {
            _context.Role.Update(role);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsSycn(Role role)
        {
            _context.Role.Remove(role);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Role role)
        {
          
        }

        public async Task DeleteById(int id)
        {

           var role = GetByRoleId(id);
            _context.Role.Remove(role);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Entity.Role> GetAll()
        {
           foreach (var role in _context.Role)
            {
                yield return role;
            }
        }

        public Role GetByBillId(int roleId)
        {
            throw new NotImplementedException();
        }

        public Role GetByRoleId(int roleId)
        {
            return _context.Role.Where(x => x.RoleId == roleId).FirstOrDefault();
        }

        public Task UpdateAsSycn(Role role)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Role role)
        {
            _context.Role.Update(role);
            await _context.SaveChangesAsync();
        }
    }
}
