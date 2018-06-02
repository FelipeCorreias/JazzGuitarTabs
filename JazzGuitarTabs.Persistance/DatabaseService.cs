using JazzGuitarTabs.Domain.Tabs;
using JazzGuitarTabs.Persistance.Tabs;
using Microsoft.EntityFrameworkCore;
using System;

namespace JazzGuitarTabs.Persistance
{
    public class DatabaseService : DbContext
    {
        public DbSet<Tab> Tabs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"User ID=postgres;Password=xxxxx;Host=xxxxxx;Port=5432;Database=xxxxx;Pooling=true;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new TabConfiguration());

        }
    }
}
