using System.Net;

namespace LocalitiesManager.Shared.Exceptions.Base;

public interface IApiExceptions
{
    string ApiMessage { get; }
    HttpStatusCode HttpStatusCode { get; }
}