using System.Reflection;
using LocalitiesManager.Api.CommandsQueries.Mappings;
using LocalitiesManager.Data;
using LocalitiesManager.Shared.Extensions;
using LocalitiesManager.Shared.Helpers;
using Microsoft.EntityFrameworkCore;
using AssemblyRunner = LocalitiesManager.Api.CommandsQueries.AssemblyRunner;

namespace LocalitiesManager.Api.Configuration;

public static class DependencyStartup
{
    public static void ConfigureServices(this WebApplicationBuilder builder)
    {
        AddInfrastructure(builder.Services);
        AddSecurity(builder.Services);
        AddCommands(builder.Services);
        ConfigureRepositories(builder.Services);
    }

    private static void AddInfrastructure(IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddMediatR(config => { config.RegisterServicesFromAssembly(typeof(AssemblyRunner).Assembly); });
        services.AddAutoMapper(config =>
        {
            config.AddProfile(new AssemblyMappingProfile(Assembly.GetExecutingAssembly()));
            config.AddProfile(new AssemblyMappingProfile(typeof(AssemblyRunner).Assembly));
        });

        if (EnvironmentHelper.IsProduction) return;

        services.AddSwaggerGen();
    }

    private static void AddSecurity(IServiceCollection services)
    {
        services.AddCors(config =>
        {
            config.AddPolicy("AllowAll", policy =>
            {
                policy.AllowAnyHeader();
                policy.AllowAnyMethod();
                policy.AllowAnyOrigin();
            });
        });
    }

    private static void AddCommands(IServiceCollection services)
    {
        services.RegisterScopedServicesEndsWith("Command", typeof(DependencyStartup).Assembly);
    }

    private static void ConfigureRepositories(IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>(x => x.UseNpgsql(AppConfiguration.DatabaseConnectionString));
        var repositoriesAssembly = typeof(Data.AssemblyRunner).Assembly;
        services.RegisterScopedServicesEndsWith("Repository", repositoriesAssembly);
    }
}