using Infrastructure.Repositories.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Repositories.Configuration
{
    public static class RepositoriesConfiguration
    {
        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
