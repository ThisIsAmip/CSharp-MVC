using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_MVC.Entity
{
    [Keyless]
    public class ProductImage
    {
        public string ImageLink { get; set; }
        public string Name { get; set; }
        [ForeignKey("Product")]
        public int ProductID{ get; set; }
    }
}
