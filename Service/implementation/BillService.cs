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
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Bill bill)
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Bill> GetAll()
        {
            throw new NotImplementedException();
        }

        public Bill GetByBillId(int billId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Bill bill)
        {
            throw new NotImplementedException();
        }
    }
}
