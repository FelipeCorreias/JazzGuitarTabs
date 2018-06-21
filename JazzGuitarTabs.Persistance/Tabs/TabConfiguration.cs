using JazzGuitarTabs.Domain.Tabs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace JazzGuitarTabs.Persistance.Tabs
{
    class TabConfiguration : IEntityTypeConfiguration<Tab>
    {
        public void Configure(EntityTypeBuilder<Tab> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Title).HasMaxLength(255);
            builder.Property(c => c.Style).HasMaxLength(255);
            
        }
    }
}
