using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Seeders
{
    internal static class ProductSeeder
    {
        internal static void SeedProducts(this ModelBuilder modelBuilder)
        {
            Product microservicesApp = new Product
            {
                Id = 1,
                Name = "codegram",
                Desciption = "better instance of instagram",
                IsActive = true,
                OrientedDeadline = new DateTime(20, 4, 2023),
                Price = 20000
            };

            Product codeGenerator = new Product
            {
                Id = 2,
                Name = "progAI",
                Desciption = "will write code instead of you(scary!)",
                IsActive = true,
                OrientedDeadline = new DateTime(20, 6, 2023),
                Price = 60000
            };

            modelBuilder.Entity<Product>().HasData(microservicesApp, codeGenerator);
        }
    }
}
