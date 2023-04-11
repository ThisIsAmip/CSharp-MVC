using Entity;
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
        Task CreateAsSycn(Role role);
        Task DeleteAsSycn(Role role);

        Task UpdateAsSycn(Role role);
        Task DeleteById(int id);

        IEnumerable<Role> GetAll();
        Role GetByRoleId(int roleId);

    }
}
