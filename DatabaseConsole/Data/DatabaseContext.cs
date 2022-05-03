using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DatabaseConsole.Models;

namespace DatabaseConsole.Data
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Transcation> Transcations { get; set; } = null!;
        public virtual DbSet<CropDetail> CropDetails { get; set; } = null!;
        public virtual DbSet<Rate> Rates { get; set; } = null!;
        public virtual DbSet<PaidStatus> PaidStatuss { get; set; } = null!;
        public virtual DbSet<FieldDetail> FieldDetails { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Test; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transcation>(entity =>
            {
                entity.HasIndex(e => e.CustomerId, "IX_PaidStatuss_CustomerId");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Transcations)
                    .HasForeignKey(d => d.CustomerId);
            });


            modelBuilder.Entity<Rate>(entity =>
            {
                entity.Property(e => e.Price).HasColumnType("decimal(6, 2)");
            });


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
