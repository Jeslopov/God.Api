using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UruIt.God.Domain.Entities;

namespace UruIt.God.Infraestructure.DbConfigs
{
    public class MatchConfig: IEntityTypeConfiguration<Match>
    {
        public void Configure(EntityTypeBuilder<Match> builder)
        {
            builder.Property(e => e.Id).HasColumnName("matchid");
            builder.HasKey(e => e.Id);
            builder.HasOne(e => e.Player1).WithMany(e => e.Matches);
            builder.HasOne(e => e.Player2);
        }
    }
}
