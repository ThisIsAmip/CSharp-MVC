using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.implementation
{
    public class BillService : IBillService
    {
        public Task CreateAsync(Bill bill)
        {
<<<<<<< HEAD
            throw new NotImplementedException();
=======
            _context = context;
        }
        public async Task CreateAsync(Bill bill)
        {
            _context.Bill.Update(bill);
            await _context.SaveChangesAsync();
>>>>>>> c356fb57eceae298f4cb0febf0378e7b20bfa5be
        }

        public Task DeleteAsync(Bill bill)
        {
<<<<<<< HEAD
            throw new NotImplementedException();
=======
            _context.Bill.Remove(bill);
            await _context.SaveChangesAsync();
>>>>>>> c356fb57eceae298f4cb0febf0378e7b20bfa5be
        }

        public Task DeleteById(int id)
        {
<<<<<<< HEAD
            throw new NotImplementedException();
=======

            var bill = GetByBillId(id);
            _context.Bill.Remove(bill);
            await _context.SaveChangesAsync();
>>>>>>> c356fb57eceae298f4cb0febf0378e7b20bfa5be
        }

        public IEnumerable<Bill> GetAll()
        {
<<<<<<< HEAD
            throw new NotImplementedException();
=======
            foreach (var bill in _context.Bill)
            {
                yield return bill;
            }
>>>>>>> c356fb57eceae298f4cb0febf0378e7b20bfa5be
        }

        public Bill GetByBillId(int billId)
        {
<<<<<<< HEAD
            throw new NotImplementedException();
=======
            return _context.Bill.Where(x => x.BillID == billId).FirstOrDefault();
>>>>>>> c356fb57eceae298f4cb0febf0378e7b20bfa5be
        }

        public Task UpdateAsync(Bill bill)
        {
<<<<<<< HEAD
            throw new NotImplementedException();
=======
            _context.Bill.Update(bill);
            await _context.SaveChangesAsync();
>>>>>>> c356fb57eceae298f4cb0febf0378e7b20bfa5be
        }

        Bill IBillService.GetByBillId(int billId)
        {
            throw new NotImplementedException();
        }
    }
}
