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
            optionsBuilder.UseNpgsql(@"User ID=xxxx;Password=xxxx;Host=xxxx;Port=5432;Database=JazzGuitarTabs;Pooling=true;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new TabConfiguration());

        }
    }
}
