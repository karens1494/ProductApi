using ChallengeDevDir.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeDevDir.Infrastructure.Data.Configurations
{
    class MarcaConfiguration : IEntityTypeConfiguration<Marca>
    {
        public void Configure(EntityTypeBuilder<Marca> builder)
        {
            builder.HasKey(e => e.IdMarca)
                    .HasName("PK__marca__7E43E99E7EF402A0");

            builder.ToTable("marca");

            builder.Property(e => e.IdMarca).HasColumnName("id_marca");

            builder.Property(e => e.Descripcion)
                .HasColumnName("descripcion")
                .HasMaxLength(100)
                .IsUnicode(false);
        }
    }
}
