using LocalitiesManager.Extensions;

namespace LocalitiesManager.Configuration;

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
        services.AddSwaggerGen();
        services.AddEndpointsApiExplorer();
    }

    private static void AddCommands(IServiceCollection services)
    {
        services.RegisterScopedServicesEndsWith("Command");
    }
}