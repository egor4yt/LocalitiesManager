using LocalitiesManager.Configuration;

AppConfiguration.CheckEnvironmentVariables();

var builder = WebApplication.CreateBuilder(args);
//builder.ConfigureServices();

var app = builder.Build();

//app.ConfigureMiddlewares();
app.MapControllers();
app.Run();