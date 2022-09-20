using Microsoft.Extensions.DependencyInjection;
using Service.Services.Abstractions;

namespace Service.Services
{
    public static class ServicesConfiguration
    {
        public static void ConfigureCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
        }
    }
}
