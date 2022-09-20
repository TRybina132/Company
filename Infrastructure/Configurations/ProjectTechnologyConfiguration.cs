using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class ProjectTechnologyConfiguration : IEntityTypeConfiguration<ProductTechnology>
    {
        public void Configure(EntityTypeBuilder<ProductTechnology> builder)
        {
            builder.HasKey(pt => new
            {
                pt.ProductId,
                pt.TechnologyId
            });

            builder.HasOne<Product>(pt => pt.Product)
                .WithMany(product => product.ProjectTechnologies)
                .HasForeignKey(pt => pt.ProductId);

            builder.HasOne<Technology>(pt => pt.Technology)
                .WithMany(tech => tech.ProjectTechnologies)
                .HasForeignKey(pt => pt.TechnologyId);
        }
    }
}
