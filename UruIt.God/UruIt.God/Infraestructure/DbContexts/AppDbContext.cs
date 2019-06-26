using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using UruIt.God.Domain.Entities;
using UruIt.God.Infraestructure.DbConfigs;

namespace UruIt.God.Infraestructure.DbContexts
{
    public class AppDbContext: DbContext
    {
        /// <summary>
        /// The DbSets for the entities
        /// </summary>
        public DbSet<User> Users { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Round> Rounds { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Applying the config for the domain entities
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new MatchConfig());
            modelBuilder.ApplyConfiguration(new RoundConfig());
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }

        
    }
}
