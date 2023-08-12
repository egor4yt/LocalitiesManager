namespace LocalitiesManager.Extensions;

public static class ThrowIfNullExtension
{
    public static void ThrowIfNull(this object obj, string message = "")
    {
        if (obj is null) throw new NullReferenceException(message);
    }
}