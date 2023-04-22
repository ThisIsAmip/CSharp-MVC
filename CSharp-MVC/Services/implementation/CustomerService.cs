using CSharp_MVC.DataAccess;
using CSharp_MVC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.implementation
{
    public class CustomerService : ICustomerService
    {
        private ApplicationDbContext _context;
        public CustomerService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Customer customer)
        {
            _context.Customer.Update(customer);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Customer customer)
        {
            _context.Customer.Remove(customer);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteById(int id)
        {

            var customer = GetByCustomerId(id);
            _context.Customer.Remove(customer);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Customer> GetAll()
        {
            foreach (var customer in _context.Customer)
            {
                yield return customer;
            }
        }

        public Customer GetByCustomerId(int customerID)
        {
            return _context.Customer.Where(x => x.CustomerID == customerID).FirstOrDefault();
        }

        public async Task UpdateAsync(Customer role)
        {
            _context.Customer.Update(role);
            await _context.SaveChangesAsync();
        }
    }
}
