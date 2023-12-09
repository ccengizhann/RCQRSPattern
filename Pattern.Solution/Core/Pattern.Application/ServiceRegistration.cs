using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services )
        {
            services.AddMediatR(configuration =>
            {
                configuration.RegisterServicesFromAssemblies(typeof(ServiceRegistration).Assembly);
                
            });

        }
    }
}
