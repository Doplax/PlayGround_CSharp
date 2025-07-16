using API.Services;

namespace API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<PersonService>();
            services.AddScoped<ProductService>();

            return services;
        }
    }
}
