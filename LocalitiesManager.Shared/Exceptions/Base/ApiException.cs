using System.Net;

namespace LocalitiesManager.Shared.Exceptions.Base;

public abstract class ApiException : Exception
{
    protected ApiException(string apiMessage, HttpStatusCode httpStatusCode)
    {
        ApiMessage = apiMessage;
        HttpStatusCode = httpStatusCode;
    }

    public string ApiMessage { get; }
    public HttpStatusCode HttpStatusCode { get; }
}