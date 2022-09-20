using Infrastructure.Repositories.Configuration;
using Service.Services;

namespace ProductAPI.Configurations
{
    internal static class ServicesConfiguration
    {
        internal static void ConfigureServices(this IServiceCollection services)
        {
            services.ConfigureCustomServices();
            services.ConfigureRepositories();
            services.AddControllers();

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

        }
    }
}
