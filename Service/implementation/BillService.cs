using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.implementation
{
    public class BillService: IBillService
    {
        private ApplicationDbContext _context;

        public BillService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Bill bill)
        {
            _context.Role.Update(bill);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Bill bill)
        {
            _context.Role.Remove(bill);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteById(int id)
        {

            var bill = GetByRoleId(id);
            _context.Role.Remove(bill);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Entity.Bill> GetAll()
        {
            foreach (var bill in _context.Role)
            {
                yield return bill;
            }
        }

        public Role GetByBilId(int billId)
        {
            return _context.Role.Where(x => x.BillId == billId).FirstOrDefault();
        }

        public async Task UpdateAsync(Bill bill)
        {
            _context.Role.Update(bill);
            await _context.SaveChangesAsync();
        }
    }
}
