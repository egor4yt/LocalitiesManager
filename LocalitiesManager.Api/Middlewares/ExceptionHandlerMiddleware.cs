using System.Net;
using LocalitiesManager.Shared.Exceptions.Base;
using LocalitiesManager.Shared.Helpers;

namespace LocalitiesManager.Api.Middlewares;

public class ExceptionHandlerMiddleware
{
    private readonly ILogger _logger;
    private readonly RequestDelegate _next;

    public ExceptionHandlerMiddleware(RequestDelegate next, ILogger logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (ApiException ex)
        {
            context.Response.ContentType = "text/plain";
            context.Response.StatusCode = (int)ex.HttpStatusCode;
            await context.Response.WriteAsync(ex.ApiMessage);
        }
        catch (Exception ex)
        {
            var responseMessage = "Something went wrong\n";

            // if (!EnvironmentHelper.IsLocal) await _logger.LogErrorAsync(ex);
            // else responseMessage += $"\n{ex.StackTrace}";
            responseMessage += $"\n{ex.StackTrace}";
            
            context.Response.ContentType = "text/plain";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            await context.Response.WriteAsync(responseMessage);
        }
    }
}