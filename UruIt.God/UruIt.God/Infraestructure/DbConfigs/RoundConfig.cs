using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UruIt.God.Domain.Entities;

namespace UruIt.God.Infraestructure.DbConfigs
{
    public class RoundConfig : IEntityTypeConfiguration<Round>
    {

        public void Configure(EntityTypeBuilder<Round> builder)
        {
            builder.Property(e => e.Id).HasColumnName("roundid");
            builder.HasKey(e => e.Id);
            builder.HasOne(e => e.Match).WithMany(e => e.Rounds).IsRequired();
            builder.HasOne(e => e.Winner);
        }

    }
}
