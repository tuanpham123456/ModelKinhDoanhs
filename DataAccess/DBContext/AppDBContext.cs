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
            modelBuilder.Entity<Payment>(entity =>
            {

            });
            modelBuilder.Entity<payment_authorization>(entity =>
            {

            });
            modelBuilder.Entity<Payment_info_cheque>(entity =>
            {

            });
            modelBuilder.Entity<Payment_invoice>(entity =>
            {

            });


        }

        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Ivoice> Ivoices { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<payment_authorization> Payment_Authorizations { get; set; }
        public virtual DbSet<Payment_invoice> Payment_Invoices { get; set; }


    }
}
