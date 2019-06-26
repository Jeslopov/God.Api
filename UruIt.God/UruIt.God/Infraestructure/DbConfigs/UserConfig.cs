using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UruIt.God.Domain.Entities;


namespace UruIt.God.Infraestructure.DbConfigs
{
    public class UserConfig: IEntityTypeConfiguration<User>
    {

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(e => e.Id).HasColumnName("userid");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).IsRequired();
        }
    }
}
