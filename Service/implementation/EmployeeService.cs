using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.implementation
{
    public class EmployeeService : IEmployeeService
    {
        private ApplicationDbContext _context;

        public EmployeeService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Employee employee)
        {
            _context.Employee.Update(employee);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Employee employee)
        {
            _context.Employee.Remove(employee);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteById(int id)
        {

            var employee = GetByEmployeeId(id);
            _context.Employee.Remove(employee);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Entity.Employee> GetAll()
        {
            foreach (var employee in _context.Employee)
            {
                yield return employee;
            }
        }

        public Employee GetByEmployeeId(int employeeID)
        {
            return _context.Employee.Where(x => x.EmployeeID == employeeID).FirstOrDefault();
        }

        public async Task UpdateAsync(Employee employee)
        {
            _context.Employee.Update(employee);
            await _context.SaveChangesAsync();
        }
    }
}
