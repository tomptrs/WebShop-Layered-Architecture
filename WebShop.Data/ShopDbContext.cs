using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Domain;
using Microsoft.AspNetCore.Identity;

namespace WebShop.Data
{
    public class ShopDbContext: IdentityDbContext<IdentityUser>
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options):base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingBag> ShoppingBags { get; set; }
        public DbSet<ShoppingItem> ShoppingItems { get; set; }

        public DbSet<Verzekering> Verzekeringen { get; set; }

        /*  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
           {
               optionsBuilder.UseSqlServer(
                   "Server=(localdb)\\mssqllocaldb;Database=webshopdb;Trusted_Connection = True;");
               base.OnConfiguring(optionsBuilder);
           }*/


    }
}
