using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_MVC.Entity
{
    public class ProductCategory
    {
        [Key]
        public int ProdCateID { get; set; }

        public string ProdCateName { get; set; }

        public ICollection<Product> Product { get;}
    }
}
