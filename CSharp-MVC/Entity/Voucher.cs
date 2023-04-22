using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_MVC.Entity
{
    public class Voucher
    {
        [Key]
        public int VoucherID { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime DateEnded { get; set; }
        public float PercentSale { get; set; }
        public float PriceSale { get; set;}

        public DateTime UseTimess { get; set; }

        public ICollection<Bill> Bill { get; set; }
    }
}
