using System;
using LocalitiesManager.Frontend.Common;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace LocalitiesManager.Frontend.Configuration;

public static class DependencyStartup
{
    public static void ConfigureServices(this WebApplicationBuilder builder)
    {
        AddInfrastructure(builder.Services);
        ConfigureApiClients(builder.Services);
    }

    private static void AddInfrastructure(IServiceCollection services)
    {
        services.AddControllersWithViews();
        services.AddHttpContextAccessor();
        services.AddRouting(options =>
        {
            options.LowercaseUrls = true;
            options.LowercaseQueryStrings = true;
        });
    }

    private static void ConfigureApiClients(IServiceCollection services)
    {
        services.AddScoped<IApiClient, ApiClient>();

        services.AddHttpClient("LocalitiesManagerApi", c =>
        {
            c.BaseAddress = new Uri(AppConfiguration.ApiUrlBase);
            c.DefaultRequestHeaders.Add("AccessToken", AppConfiguration.ApiAccessToken);
        });
    }
}