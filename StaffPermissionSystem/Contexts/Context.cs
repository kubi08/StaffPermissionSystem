using Microsoft.EntityFrameworkCore;
using StaffPermissionSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffPermissionSystem.Contexts
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }
        

       public DbSet<ProductCategory> ProductCategories { get; set; }
       public DbSet<Category> Categories { get; set; }
       public DbSet<Product> Products { get; set; }

    }
}
