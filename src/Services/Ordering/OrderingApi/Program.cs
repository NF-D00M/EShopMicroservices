using OrderingApi;
using OrderingApplication;
using OrderingInfrastructure;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services
    .AddApplicationServices()
    .AddInfrastructureServices(builder.Configuration)
    .AddApiServices();

var app = builder.Build();

// Configure the Http Request pipeline

app.Run();