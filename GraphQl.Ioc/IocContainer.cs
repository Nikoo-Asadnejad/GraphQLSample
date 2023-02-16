using GraphQl.Infrastructure.Configurations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQl.Ioc;

public static class IocContainer
{
    public static void InjectAppServices(this IServiceCollection services, IConfiguration config)
    {
        services.InjectInfraServices(config);
    } 
}