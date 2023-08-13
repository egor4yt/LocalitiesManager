using System.Net;
using LocalitiesManager.Shared.Exceptions.Base;

namespace LocalitiesManager.Shared.Exceptions;

public class BadRequestException : ApiException
{
    public BadRequestException(string apiMessage) : base(apiMessage, HttpStatusCode.BadRequest)
    {
    }
}