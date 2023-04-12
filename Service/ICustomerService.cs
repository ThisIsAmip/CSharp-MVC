using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface ICustomerService
    {
        //thêm, sửa, xóa, get all, ...
        Task CreateAsync(Customer customer);
        Task DeleteAsync(Customer customer);

        Task UpdateAsync(Customer customer);
        Task DeleteById(int id);

        IEnumerable<Customer> GetAll();
        Customer GetByCustomerId(int CustomerID);
    }
}
