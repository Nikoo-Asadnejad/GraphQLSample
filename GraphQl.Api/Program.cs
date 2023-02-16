using GraphQl.Api.Configurations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.InjectServices(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
app.ConfigurePipeline();
app.Run();