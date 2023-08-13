using System.Net;
using LocalitiesManager.Shared.Exceptions.Base;

namespace LocalitiesManager.Shared.Exceptions;

public class NotFoundException : ApiException
{
    public NotFoundException(string apiMessage) : base(apiMessage, HttpStatusCode.NotFound)
    {
    }
}