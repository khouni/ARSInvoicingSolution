using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace _00.Infrastructure.Models
{
    public partial class ARSDataBaeContext : DbContext
    {
        public ARSDataBaeContext()
        {
        }

        public ARSDataBaeContext(DbContextOptions<ARSDataBaeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerType> CustomerType { get; set; }
        public virtual DbSet<Employe> Employe { get; set; }
        public virtual DbSet<Employment> Employment { get; set; }
        public virtual DbSet<HourlyRate> HourlyRate { get; set; }
        public virtual DbSet<InterventionType> InterventionType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=ARS.DataBae;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currency>(entity =>
            {
                entity.Property(e => e.CurrencyId).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.TaxRegistrationNumber);

                entity.Property(e => e.TaxRegistrationNumber)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.SocialReason)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TradeRegister)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_CustomerType");
            });

            modelBuilder.Entity<CustomerType>(entity =>
            {
                entity.HasKey(e => e.CustomerTypeTypeId);

                entity.Property(e => e.CustomerTypeTypeId).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Employe>(entity =>
            {
                entity.HasKey(e => e.RegistrationNumber);

                entity.Property(e => e.RegistrationNumber).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Employment)
                    .WithMany(p => p.Employe)
                    .HasForeignKey(d => d.EmploymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employe_Employment");
            });

            modelBuilder.Entity<Employment>(entity =>
            {
                entity.Property(e => e.EmploymentId).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<HourlyRate>(entity =>
            {
                entity.Property(e => e.HourlyRateId).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.PriceWithoutTaxe).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.HourlyRate)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HourlyRate_Currency");

                entity.HasOne(d => d.CustomerType)
                    .WithMany(p => p.HourlyRate)
                    .HasForeignKey(d => d.CustomerTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HourlyRate_CustomerType");

                entity.HasOne(d => d.HourlyRateNavigation)
                    .WithOne(p => p.InverseHourlyRateNavigation)
                    .HasForeignKey<HourlyRate>(d => d.HourlyRateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HourlyRate_HourlyRate");

                entity.HasOne(d => d.InterventionType)
                    .WithMany(p => p.HourlyRate)
                    .HasForeignKey(d => d.InterventionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HourlyRate_InterventionType");
            });

            modelBuilder.Entity<InterventionType>(entity =>
            {
                entity.Property(e => e.InterventionTypeId).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });
        }
    }
}
