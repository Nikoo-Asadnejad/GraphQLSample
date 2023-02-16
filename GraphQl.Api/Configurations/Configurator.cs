using GraphQl.Api.Queries;
using GraphQl.Core.Types;
using GraphQl.Ioc;

namespace GraphQl.Api.Configurations;

public static class Configurator
{
    public static void InjectServices(this IServiceCollection services, IConfiguration config)
    {
        services.InjectAppServices(config);
        services.AddGraphQLServer()
            .AddQueryType<AppQuery>()
            .AddType<UserType>();
    }

    public static void ConfigurePipeline(this WebApplication app)
    {
        
        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapGraphQL("/api/graphql");
        });

       
    }
}