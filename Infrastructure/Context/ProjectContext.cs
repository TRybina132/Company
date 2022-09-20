using Domain.Entities;
using Infrastructure.Configurations;
using Infrastructure.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Infrastructure.Context
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductTechnology> ProductTechnologies { get; set; }
        public DbSet<Technology> Technologies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProjectTechnologyConfiguration).Assembly);

            modelBuilder.SeedProducts();
            modelBuilder.SeedTechnologies();
        }

        public ProductContext(DbContextOptions options) : base(options) { }
    }
}
