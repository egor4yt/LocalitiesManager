using LocalitiesManager.Api.Extensions;
using LocalitiesManager.Api.Helpers;

namespace LocalitiesManager.Api.Configuration;

public static class DependencyStartup
{
    public static void ConfigureServices(this WebApplicationBuilder builder)
    {
        AddInfrastructure(builder.Services);
        AddCommands(builder.Services);
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
        services.RegisterScopedServicesEndsWith("Command");
    }
}