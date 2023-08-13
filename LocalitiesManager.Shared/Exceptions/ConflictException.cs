using System.Net;
using LocalitiesManager.Shared.Exceptions.Base;

namespace LocalitiesManager.Shared.Exceptions;

public class ConflictException : ApiException
{
    public ConflictException(string apiMessage) : base(apiMessage, HttpStatusCode.Conflict)
    {
    }
}