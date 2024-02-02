using Sample.GraphQL.Mutations;
using Sample.GraphQL.Queries;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGraphQLServer()
                .AddQueryType<UserQueryService>()
                .AddMutationType<UserMutationService>();

var app = builder.Build();

app.MapGraphQL();

app.Run();