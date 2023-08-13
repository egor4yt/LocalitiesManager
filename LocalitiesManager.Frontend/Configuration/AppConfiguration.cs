namespace LocalitiesManager.Frontend.Configuration;

public static class AppConfiguration
{
    public static string ApiAccessToken { get; private set; } = Environment.GetEnvironmentVariable("API_ACCESS_TOKEN") ?? "bdb477f2-679e-4b9b-aa81-a52ddfe23ca3";
    public static string ApiUrlBase { get; private set; } = Environment.GetEnvironmentVariable("API_URL_BASE") ?? "https://localhost:64866/";
}