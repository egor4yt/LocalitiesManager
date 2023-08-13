using LocalitiesManager.Api.Middlewares;

namespace LocalitiesManager.Api.Configuration;

public static class MiddlewaresConfiguration
{
    public static void ConfigureMiddlewares(this WebApplication app)
    {
        app.UseRouting();
        app.UseMiddleware<ExceptionHandlerMiddleware>();

        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseCors("AllowAll");
        app.UseHsts();
        app.UseHttpsRedirection();

        app.MapControllers();
    }
}