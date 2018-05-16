using System;
using MemeBuilderData.Models;
using Microsoft.EntityFrameworkCore;

namespace MemeBuilderData
{
    public class MemeBuilderContext : DbContext
    {
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
