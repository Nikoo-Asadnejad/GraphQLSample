using GraphQl.Api.Configurations;
using GraphQl.Api.Queries;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.InjectServices(builder.Configuration);


var app = builder.Build();

// Configure the HTTP request pipeline.

app.Run();