using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Mappers
{
    class BargainTypeConfiguration : IEntityTypeConfiguration<BargainType>
    {
        public void Configure(EntityTypeBuilder<BargainType> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).HasMaxLength(100);
        }
    }
}
