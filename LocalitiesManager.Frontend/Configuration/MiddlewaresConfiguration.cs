using Microsoft.AspNetCore.Builder;

namespace LocalitiesManager.Frontend.Configuration;

public static class MiddlewaresConfiguration
{
    public static void ConfigureMiddlewares(this WebApplication app)
    {
        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.MapControllers();
    }
}