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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasMany(I => I.ProductCategories)
                .WithOne(I => I.Product).HasForeignKey(I => I.ProductId);

            modelBuilder.Entity<Category>().HasMany(I => I.ProductCategories)
               .WithOne(I => I.Category).HasForeignKey(I => I.ProductId);
            modelBuilder.Entity<ProductCategory>().HasIndex(I => new
            {
                I.CategoryId,
                I.ProductId

            }).IsUnique();
        }

        public DbSet<ProductCategory> ProductCategories { get; set; }
       public DbSet<Category> Categories { get; set; }
       public DbSet<Product> Products { get; set; }

    }
}
