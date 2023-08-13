using LocalitiesManager.Api.Extensions;
using LocalitiesManager.Api.Helpers;
using LocalitiesManager.Data;
using Microsoft.EntityFrameworkCore;

namespace LocalitiesManager.Api.Configuration;

public static class DependencyStartup
{
    public static void ConfigureServices(this WebApplicationBuilder builder)
    {
        AddInfrastructure(builder.Services);
        AddCommands(builder.Services);
        ConfigureRepositories(builder.Services);
    }

    private static void AddInfrastructure(IServiceCollection services)
    {
        services.AddControllers();
        services.AddHttpContextAccessor();
        services.AddMemoryCache();
        services.AddEndpointsApiExplorer();

        if (EnvironmentHelper.IsProduction) return;

        services.AddSwaggerGen();
    }

    private static void AddCommands(IServiceCollection services)
    {
        services.RegisterScopedServicesEndsWith("Command", typeof(DependencyStartup).Assembly);
    }

    private static void ConfigureRepositories(IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>(x => x.UseNpgsql(AppConfiguration.DatabaseConnectionString));
        var repositoriesAssembly = typeof(AssemblyRunner).Assembly;
        services.RegisterScopedServicesEndsWith("Repository", repositoriesAssembly);
    }
}