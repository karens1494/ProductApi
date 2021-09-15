using ChallengeDevDir.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeDevDir.Infrastructure.Data.Configurations
{
    class PresentacionConfiguration : IEntityTypeConfiguration<Presentacion>
    {
        public void Configure(EntityTypeBuilder<Presentacion> builder)
        {
            builder.HasKey(e => e.IdPresentacion)
                    .HasName("PK__presenta__5F94E0ED6A3DB40D");

            builder.ToTable("presentacion");

            builder.Property(e => e.IdPresentacion).HasColumnName("id_presentacion");

            builder.Property(e => e.Descripcion)
                .HasColumnName("descripcion")
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
