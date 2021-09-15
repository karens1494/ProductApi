using ChallengeDevDir.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChallengeDevDir.Infrastructure.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.HasKey(e => e.IdProducto)
                     .HasName("PK__producto__FF341C0D52821CFB");

            builder.ToTable("producto");

            builder.Property(e => e.IdProducto).HasColumnName("id_producto");

            builder.Property(e => e.Codigo).HasColumnName("codigo");

            builder.Property(e => e.DescripcionProducto)
                .HasColumnName("descripcion_producto")
                .HasMaxLength(1000)
                .IsUnicode(false);

            builder.Property(e => e.IdMarca).HasColumnName("id_marca");

            builder.Property(e => e.IdPresentacion).HasColumnName("id_presentacion");

            builder.Property(e => e.IdProveedor).HasColumnName("id_proveedor");

            builder.Property(e => e.IdZona).HasColumnName("id_zona");

            builder.Property(e => e.Iva).HasColumnName("iva");

            builder.Property(e => e.Peso).HasColumnName("peso");

            builder.Property(e => e.Precio).HasColumnName("precio");

            builder.Property(e => e.Stock).HasColumnName("stock");

            builder.HasOne(d => d.Marca)
                .WithMany(p => p.Producto)
                .HasForeignKey(d => d.IdMarca)
                .HasConstraintName("FK__producto__id_mar__45F365D3");

            builder.HasOne(d => d.Presentacion)
                .WithMany(p => p.Producto)
                .HasForeignKey(d => d.IdPresentacion)
                .HasConstraintName("FK__producto__id_pre__46E78A0C");

            builder.HasOne(d => d.Proveedor)
                .WithMany(p => p.Producto)
                .HasForeignKey(d => d.IdProveedor)
                .HasConstraintName("FK__producto__id_pro__47DBAE45");

            builder.HasOne(d => d.Zona)
                .WithMany(p => p.Producto)
                .HasForeignKey(d => d.IdZona)
                .HasConstraintName("FK__producto__id_zon__48CFD27E");
        }
    }


}
