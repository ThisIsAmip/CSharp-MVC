using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.implementation
{
    public class VoucherService : IVoucherService
    {
        private ApplicationDbContext _context;
        public VoucherService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Voucher voucher)
        {
            _context.Voucher.Update(voucher);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Voucher voucher)
        {
            _context.Voucher.Remove(voucher);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteById(int id)
        {

            var voucher = GetByVoucherId(id);
            _context.Voucher.Remove(voucher);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Entity.Voucher> GetAll()
        {
            foreach (var voucher in _context.Voucher)
            {
                yield return voucher;
            }
        }

        public Voucher GetByVoucherId(int voucherID)
        {
            return _context.Voucher.Where(x => x.VoucherID == voucherID).FirstOrDefault();
        }

        public async Task UpdateAsync(Voucher voucher)
        {
            _context.Voucher.Update(voucher);
            await _context.SaveChangesAsync();
        }
    }
}
