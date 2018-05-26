using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MemeBuilder.Models
{
    public class TemplateConfiguration : IEntityTypeConfiguration<Template>
    {
        public void Configure(EntityTypeBuilder<Template> builder)
        {
            builder
                .HasKey(p => p.Id);

            builder
                .Property(p => p.CreatedOn)
                .HasColumnType("TIMESTAMP(2)")
                .IsRequired();

            builder
                .Property(p => p.Description)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
