using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Seeders
{
    internal static class TechnologySeeder
    {
        internal static void SeedTechnologies(this ModelBuilder modelBuilder)
        {
            Technology aspnet = new Technology
            {
                TechnologyId = 1,
                Name = "ASP.NET"
            };

            Technology cSharp = new Technology
            {
                TechnologyId = 2,
                Name = "C#"
            };

            Technology ef = new Technology
            {
                TechnologyId = 3,
                Name = "EntityFramework"
            };

            Technology angular = new Technology
            {
                TechnologyId = 4,
                Name = "Angular"
            };

            modelBuilder.Entity<Technology>()
                .HasData(aspnet,cSharp,ef,angular);
        }
    }
}
