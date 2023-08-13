using LocalitiesManager.Api.Configuration;
using LocalitiesManager.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.ConfigureServices();

var app = builder.Build();

/* auto migrate database */
var scope = app.Services.CreateScope();
var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
dbContext.Database.Migrate();

//app.ConfigureMiddlewares();
app.MapControllers();
app.Run();