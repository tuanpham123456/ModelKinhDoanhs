using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.DBContext
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() { }
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        { }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>(entity =>
            {

            });
            modelBuilder.Entity<Ivoice>(entity =>
            {

            });
            modelBuilder.Entity<Ivoice>(entity =>
            {

            });

        }

        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Ivoice> Ivoices { get; set; }

    }
}
