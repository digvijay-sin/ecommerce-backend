using ecommerceApp.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerceApp.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        DbSet<Admin> Admins { get; set; }
        DbSet<Customer> Cutomers{ get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Seller> Sellers{ get; set; }

        protected  override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.Entity<User>()
               .HasMany(u => u.UserRoles)
               .WithOne(ur => ur.User)
               .HasForeignKey(ur => ur.Uid)
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Role>()
                .HasMany(r => r.UserRoles)
                .WithOne(ur => ur.Role)
                .HasForeignKey(ur => ur.RoleId)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<Seller>()
                .HasOne(s => s.User)
                .WithOne()
                .HasForeignKey<Seller>(s => s.Uid)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Customer>()
                .HasOne(c => c.User)
                .WithOne()
                .HasForeignKey<Customer>(c => c.Uid)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Admin>()
                .HasOne(a => a.User)
                .WithOne()
                .HasForeignKey<Admin>(a => a.Uid)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
