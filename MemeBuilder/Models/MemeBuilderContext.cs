using System;
using Microsoft.EntityFrameworkCore;

namespace MemeBuilder.Models
{
    public class MemeBuilderContext : DbContext
    {
        public MemeBuilderContext()
        { }

        public MemeBuilderContext(DbContextOptions<MemeBuilderContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TemplateConfiguration());
        }

        public DbSet<Template> Template { get; set; }
    }
}
