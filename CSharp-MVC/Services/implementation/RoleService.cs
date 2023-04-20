﻿using CSharp_MVC.DataAccess;
using CSharp_MVC.Entity;
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
        public async Task CreateAsync(Role role)
        {
            _context.Role.Update(role);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Role role)
        {
           _context.Role.Remove(role);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteById(int id)
        {

           var role = GetByRoleId(id);
            _context.Role.Remove(role);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Role> GetAll()
        {
           foreach (var role in _context.Role)
            {
                yield return role;
            }
        }

        public Role GetByRoleId(int roleId)
        {
            return _context.Role.Where(x => x.RoleId == roleId).FirstOrDefault();
        }

        public async Task UpdateAsync(Role role)
        {
            _context.Role.Update(role);
            await _context.SaveChangesAsync();
        }
    }
}