using JazzGuitarTabs.Domain.Artists;
using JazzGuitarTabs.Domain.Tabs;
using JazzGuitarTabs.Persistance.Artists;
using JazzGuitarTabs.Persistance.Tabs;
using Microsoft.EntityFrameworkCore;
using System;

namespace JazzGuitarTabs.Persistance
{
    public class DatabaseService : DbContext
    {
        public DbSet<Tab> Tabs { get; set; }
        public DbSet<Artist> Artist { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"User ID=postgres;Password=xxxxx;Host=xxxxx;Port=5432;Database=JazzGuitarTabs;Pooling=true;");
            //optionsBuilder.UseNpgsql(@"User ID=postgres;Password=xxxxx;Host=172.18.0.6;Port=5432;Database=JazzGuitarTabs;Pooling=true;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new TabConfiguration());
            modelBuilder.ApplyConfiguration(new ArtistConfiguration());

        }
    }
}
