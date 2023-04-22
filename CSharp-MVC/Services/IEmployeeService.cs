using CSharp_MVC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IEmployeeService
    {
        //thêm, sửa, xóa, get all, ...
        Task CreateAsync(Employee employee);
        Task DeleteAsync(Employee employee);

        Task UpdateAsync(Employee employee);
        Task DeleteById(int id);

        IEnumerable<Employee> GetAll();
        Employee GetByEmployeeId(int employeeID);
    }
}
