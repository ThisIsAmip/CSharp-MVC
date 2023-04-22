using CSharp_MVC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IRoleService
    {
        //thêm, sửa, xóa, lấy all, ...
        Task CreateAsync(Role role);
        Task DeleteAsync(Role role);

        Task UpdateAsync(Role role);
        Task DeleteById(int id);

        IEnumerable<Role> GetAll();
        Role GetByRoleId(int roleId);

    }
}
