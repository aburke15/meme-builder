using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MemeBuilderData.Models
{
    public class TemplateConfiguration : IEntityTypeConfiguration<Template>
    {
        public void Configure(EntityTypeBuilder<Template> builder)
        {
            builder
                .HasKey(prop => prop.Id);

            builder
                .Property(prop => prop.CreatedOn)
                .HasColumnType("DATETIME(2)")
                .IsRequired();

            builder
                .Property(prop => prop.Description)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
