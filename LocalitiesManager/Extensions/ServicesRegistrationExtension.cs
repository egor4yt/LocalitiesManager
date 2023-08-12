namespace LocalitiesManager.Extensions;

public static class ServiceCollectionExtension
{
    public static void RegisterScopedServicesEndsWith(this IServiceCollection services, string value)
    {
        var assembly = typeof(ServiceCollectionExtension).Assembly;
        var classes = assembly.GetTypes().Where(x => x.Name.EndsWith(value) && x.IsClass);

        foreach (var @class in classes)
        {
            var @interface = @class.GetInterfaces().First(x => x.Name.EndsWith(value));
            services.AddScoped(@interface, @class);
        }
    }
}