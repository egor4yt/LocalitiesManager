namespace LocalitiesManager.Api.Helpers;

public static class EnvironmentHelper
{
    public static readonly bool IsProduction = string.IsNullOrWhiteSpace(Environment.GetEnvironmentVariable("ENVIRONMENT"));
    public static readonly bool IsLocal = Environment.GetEnvironmentVariable("ENVIRONMENT") == "Local";
}