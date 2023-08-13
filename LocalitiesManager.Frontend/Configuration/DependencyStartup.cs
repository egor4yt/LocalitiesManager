namespace LocalitiesManager.Frontend.Configuration;

public static class DependencyStartup
{
    public static void ConfigureServices(this WebApplicationBuilder builder)
    {
        AddInfrastructure(builder.Services);
    }

    private static void AddInfrastructure(IServiceCollection services)
    {
        services.AddControllersWithViews();
    }
}