using CSharp_MVC.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CSharp_MVC.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Role> Role { get; set; }
        public DbSet<User> TaiKhoan { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Customer> Customer { get; set; }

        public DbSet<Voucher> Voucher { get; set; }

        public DbSet<Bill> Bill { get; set; }

        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<ProductImage> ProductImage { get; set; }
        public DbSet<Entity.ProductInfo> ProductInfo { get; set; }
        public DbSet<Product> Product { get; set; }

        public DbSet<ProductSale> ProductSale { get; set; }

        public DbSet<ProductBill> ProductBill { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductBill>()
            .HasKey(m => new { m.ProductID, m.BillID });
            base.OnModelCreating(modelBuilder);
        }
    }
}
