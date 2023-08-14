using System.Threading.Tasks;
using LocalitiesManager.Frontend.Common;
using LocalitiesManager.Frontend.Contracts.Houses.Filter;
using Microsoft.AspNetCore.Mvc;

namespace LocalitiesManager.Frontend.Controllers.Api;

[Route("api/houses")]
public class ApiHousesController : ControllerBase
{
    private readonly IApiClient _apiClient;

    public ApiHousesController(IApiClient apiClient)
    {
        _apiClient = apiClient;
    }

    [HttpGet("filter")]
    public async Task<IActionResult> Filter([FromQuery] int skip, [FromQuery] int count)
    {
        var response = await _apiClient.GetAsync<FilterHousesResponse>("houses/filter");
        return Ok(response);
    }
}