using CSharp_MVC.DataAccess;
using CSharp_MVC.Entity;
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
            _context.Bill.Update(bill);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Bill bill)
        {
            _context.Bill.Remove(bill);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteById(int id)
        {

            var bill = GetByBillId(id);
            _context.Bill.Remove(bill);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Bill> GetAll()
        {
            foreach (var bill in _context.Bill)
            {
                yield return bill;
            }
        }

        public Bill GetByBillId(int billId)
        {
            return _context.Bill.Where(x => x.BillID == billId).FirstOrDefault();
        }

        public async Task UpdateAsync(Bill bill)
        {
            _context.Bill.Update(bill);
            await _context.SaveChangesAsync();
        }

        Bill IBillService.GetByBillId(int billId)
        {
            throw new NotImplementedException();
        }
    }
}
