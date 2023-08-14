using LocalitiesManager.Frontend.Configuration;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
builder.ConfigureServices();

var app = builder.Build();
app.ConfigureMiddlewares();

app.Run();