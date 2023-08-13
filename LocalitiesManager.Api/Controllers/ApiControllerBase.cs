using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LocalitiesManager.Api.Controllers;

[ApiController]
[Produces("application/json")]
[ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
public abstract class ApiControllerBase : ControllerBase
{
    private IMediator _mediator;
    protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
}