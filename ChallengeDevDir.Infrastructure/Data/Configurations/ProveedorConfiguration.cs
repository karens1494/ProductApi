using ChallengeDevDir.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeDevDir.Infrastructure.Data.Configurations
{
    class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>
    {
        public void Configure(EntityTypeBuilder<Proveedor> builder)
        {
            builder.HasKey(e => e.IdProveedor)
                    .HasName("PK__proveedo__8D3DFE28DCEB604B");

            builder.ToTable("proveedor");

            builder.Property(e => e.IdProveedor).HasColumnName("id_proveedor");

            builder.Property(e => e.Descripcion)
                .HasColumnName("descripcion")
                .HasMaxLength(100)
                .IsUnicode(false);
        }
    }
}
