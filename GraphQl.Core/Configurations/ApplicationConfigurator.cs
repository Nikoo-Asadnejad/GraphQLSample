using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQl.Core.Configurations;

public static class ApplicationConfigurator
{
    public static void InjectServices(this IServiceCollection services, IConfiguration config)
    {
        services.InjectServices(config);
    }
}