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
            modelBuilder.Entity<Payment_authorization>(entity =>
            {

            });
            modelBuilder.Entity<Payment_info_cheque>(entity =>
            {

            });
            modelBuilder.Entity<Payment_invoice>(entity =>
            {

            });
            modelBuilder.Entity<Payment_vnp>(entity =>
            {

            });
            modelBuilder.Entity<Payment_momo>(entity =>
            {

            });
            modelBuilder.Entity<Config>(entity =>
            {

            });
            modelBuilder.Entity<Invoice_line>(entity =>
            {

            });
            modelBuilder.Entity<Payment_result>(entity =>
            {

            });
            modelBuilder.Entity<Payment_method>(entity =>
            {

            });
            modelBuilder.Entity<Customer>(entity =>
            {

            });
            modelBuilder.Entity<Partner>(entity =>
            {

            });
        }

        public virtual DbSet<Member> Members { get; set; }
        
        public virtual DbSet<Ivoice> Ivoices { get; set; }
        
        public virtual DbSet<Payment> Payments { get; set; }
        
        public virtual DbSet<Payment_authorization> Payment_authorizations { get; set; }

        public virtual DbSet<Payment_info_cheque> Payment_info_cheques { get; set; }
        
        public virtual DbSet<Payment_invoice> Payment_invoices { get; set; }

        public virtual DbSet<Payment_vnp> Payment_vnps { get; set; }
        
        public virtual DbSet<Payment_momo> Payment_momos { get; set; }
        
        public virtual DbSet<Config> Configs { get; set; }
        
        public virtual DbSet<Invoice_line> Invoice_lines { get; set; }

        public virtual DbSet<Payment_result> Payment_results { get; set; }

        public virtual DbSet<Payment_method> Payment_methods { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Partner> Partners { get; set; }


    }
}
