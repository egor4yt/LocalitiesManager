namespace LocalitiesManager.Api.Configuration;

public static class AppConfiguration
{
    public static string ApiAccessToken { get; private set; } = Environment.GetEnvironmentVariable("API_ACCESS_TOKEN") ?? "bdb477f2-679e-4b9b-aa81-a52ddfe23ca3";
    public static string DatabaseConnectionString { get; private set; } = Environment.GetEnvironmentVariable("DATABASE_CONNECTION_STRING") ?? "host=localhost;port=5432;database=LocalitiesManager;username=postgres;password=postgres";
}