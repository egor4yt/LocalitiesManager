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

app.UseRouting();
app.UseHttpsRedirection();
app.UseDeveloperExceptionPage();
app.UseCors("AllowAll");

app.UseSwagger();
app.UseSwaggerUI();

//app.ConfigureMiddlewares();
app.MapControllers();
app.Run();