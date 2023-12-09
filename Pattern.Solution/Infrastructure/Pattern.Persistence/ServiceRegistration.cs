using Microsoft.Extensions.DependencyInjection;
using Pattern.Application.Repositories.CustomerRepositories;
using Pattern.Application.Repositories.ProductRepositories;
using Pattern.Persistence.Contexts;
using Pattern.Persistence.Repositories.CustomerRepositories;
using Pattern.Persistence.Repositories.ProductRepositories;

namespace Pattern.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddDbContext<PatternDbContext>();
        }
    }
}
