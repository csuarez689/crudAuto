using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudAuto.Models
{
    public class crudAutoDbContext : DbContext
    {
        public crudAutoDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Auto> Autos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Auto>(entity =>
            {
                entity.ToTable("auto");

                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Patente).HasColumnName("patente").IsRequired().HasMaxLength(7);
                entity.HasIndex(e => e.Patente).IsUnique();

                entity.Property(e => e.Marca).HasColumnName("marca").IsRequired().HasMaxLength(120).IsUnicode(false);

                entity.Property(e => e.Modelo).HasColumnName("modelo").IsRequired().HasMaxLength(120).IsUnicode(false);

                entity.Property(e => e.Año).HasColumnName("anio").IsRequired();

                entity.Property(e => e.Kms).HasColumnName("kms").IsRequired();

                entity.Property(e => e.Imagen).HasColumnName("imagen");
            });

        }

    }
}

