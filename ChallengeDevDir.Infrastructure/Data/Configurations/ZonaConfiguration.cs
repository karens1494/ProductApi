using ChallengeDevDir.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeDevDir.Infrastructure.Data.Configurations
{
    class ZonaConfiguration : IEntityTypeConfiguration<Zona>
    {
        public void Configure(EntityTypeBuilder<Zona> builder)
        {
            builder.HasKey(e => e.IdZona)
                     .HasName("PK__zona__67C936112222D45E");

            builder.ToTable("zona");

            builder.Property(e => e.IdZona).HasColumnName("id_zona");

            builder.Property(e => e.Descripcion)
                .HasColumnName("descripcion")
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
