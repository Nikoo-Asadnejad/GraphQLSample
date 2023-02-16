using GraphQl.Api.Queries;
using GraphQl.Core.Types;

namespace GraphQl.Api.Configurations;

public static class Configurator
{
    public static void InjectServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        services.AddEndpointsApiExplorer();
      //  services.AddSwaggerGen();
        services.InjectServices(config);
        services.AddGraphQLServer()
            .AddQueryType<AppQuery>()
            .AddType<UserType>();
    }

    public static void ConfigurePipeline(this WebApplication app)
    {
        
        // if (app.Environment.IsDevelopment())
        // {
        //     app.UseSwagger();
        //     app.UseSwaggerUI();
        // }
        app.UseRouting();
       // app.UseHttpsRedirection();

      //  app.UseAuthorization();

      //  app.MapControllers();
        
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapGraphQL("/api/graphql");
        });

       
    }
}