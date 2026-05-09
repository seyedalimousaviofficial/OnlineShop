using Catalog.Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Infrastracture.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(p => p.ShortDescription)
                .IsRequired()
                .HasMaxLength(150);
            builder.Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(200);
            builder.HasOne(x => x.Brands)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.BrandId);
            builder.HasOne(x => x.Categories)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.CategoryId);
        }
    }
}
