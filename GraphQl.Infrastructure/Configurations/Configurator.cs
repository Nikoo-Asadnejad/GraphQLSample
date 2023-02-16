using GraphQl.Core.Interfaces;
using GraphQl.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoRepository.Configurations;

namespace GraphQl.Infrastructure.Configurations;

public static class InfrastructureConfigurator
{
    public static void InjectServices(this IServiceCollection services, IConfiguration config)
    {
        MongoRepositoryDllConfigurator.InjectServices(services);
        services.AddScoped<IUserService, UserService>();
    }
}