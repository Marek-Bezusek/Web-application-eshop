using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ProjectEshop.Models
{
    public partial class EshopContext : DbContext
    {
        public EshopContext()
        {
        }

        public EshopContext(DbContextOptions<EshopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<ManufacturerLogo> ManufacturerLogos { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<Score> Scores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:EshopDatabase");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Manufacturer>(entity =>
            {
                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.ManufacturerName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ManufacturerLogo>(entity =>
            {
                entity.Property(e => e.Logo).IsRequired();

                entity.HasOne(d => d.IdManufacturerNavigation)
                    .WithMany(p => p.ManufacturerLogos)
                    .HasForeignKey(d => d.IdManufacturer)
                    .HasConstraintName("FK_ManufacturerLogos_Manufacturers");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductDescription)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdCategoryNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.IdCategory)
                    .HasConstraintName("FK_Products_Categories");

                entity.HasOne(d => d.IdManufacturerNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.IdManufacturer)
                    .HasConstraintName("FK_Products_Manufacturers");
            });

            modelBuilder.Entity<ProductImage>(entity =>
            {
                entity.Property(e => e.Picture).IsRequired();

                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany(p => p.ProductImages)
                    .HasForeignKey(d => d.IdProduct)
                    .HasConstraintName("FK_ProductImages_Products");
            });

            modelBuilder.Entity<Score>(entity =>
            {
                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany(p => p.Scores)
                    .HasForeignKey(d => d.IdProduct)
                    .HasConstraintName("FK_Scores_Products");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
