using Microsoft.Extensions.DependencyInjection;

namespace Application.Services.Configuration
{
    public static class CustomServicesConfiguration
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<ProductService>();
        }
    }
}
