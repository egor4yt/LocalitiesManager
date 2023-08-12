using LocalitiesManager.Api.Helpers;
using LocalitiesManager.Api.Extensions;

namespace LocalitiesManager.Api.Configuration;

public static class AppConfiguration
{
    public static string ApiAccessToken { get; private set; } = Environment.GetEnvironmentVariable("API_ACCESS_TOKEN");

    public static void CheckEnvironmentVariables()
    {
        if (EnvironmentHelper.IsProduction)
        {
            ApiAccessToken.ThrowIfNull();
        }

        if (EnvironmentHelper.IsLocal)
        {
            ApiAccessToken = "bdb477f2-679e-4b9b-aa81-a52ddfe23ca3";
        }
    }
}