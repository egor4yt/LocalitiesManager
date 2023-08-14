using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace LocalitiesManager.Frontend.Common;

public class ApiClient : IApiClient
{
    private readonly HttpClient _client;
    private readonly ILogger<ApiClient> _logger;

    public ApiClient(IHttpClientFactory httpClientFactory, ILogger<ApiClient> logger)
    {
        _logger = logger;
        _client = httpClientFactory.CreateClient("LocalitiesManagerApi");
    }

    public async Task<ApiResponse<TResponse?>> GetAsync<TResponse>(string url)
    {
        var response = new ApiResponse<TResponse?>();

        try
        {
            var apiResponse = await _client.GetAsync(url);
            response.ApiHttpStatusCode = (int)apiResponse.StatusCode;
            response.RawPayload = await apiResponse.Content.ReadAsStringAsync();

            switch (response.ApiHttpStatusCode)
            {
                case >= 200 and <= 299 when string.IsNullOrWhiteSpace(response.RawPayload) == false:
                    response.Payload = await apiResponse.Content.ReadFromJsonAsync<TResponse>();
                    break;
                case < 200 or > 299:
                    if (string.IsNullOrWhiteSpace(response.RawPayload) == false) _logger.LogWarning("Not success http status code from api: {ResponseRawPayload}", response.RawPayload);
                    break;
            }
        }
        catch (Exception e)
        {
            _logger.LogError(null, e);
            response.ApiHttpStatusCode = (int)HttpStatusCode.InternalServerError;
            response.RawPayload = e.Message;
        }

        return response;
    }

    public async Task<ApiResponse<TResponse?>> PostAsync<TResponse, TRequest>(string url, TRequest request)
    {
        var response = new ApiResponse<TResponse?>();

        try
        {
            var apiResponse = await _client.PostAsJsonAsync(url, request);
            response.ApiHttpStatusCode = (int)apiResponse.StatusCode;
            response.RawPayload = await apiResponse.Content.ReadAsStringAsync();

            switch (response.ApiHttpStatusCode)
            {
                case >= 200 and <= 299 when string.IsNullOrWhiteSpace(response.RawPayload) == false:
                    response.Payload = await apiResponse.Content.ReadFromJsonAsync<TResponse>();
                    break;
                case < 200 or > 299:
                    if (string.IsNullOrWhiteSpace(response.RawPayload) == false) _logger.LogWarning("Not success http status code from api: {ResponseRawPayload}", response.RawPayload);
                    break;
            }
        }
        catch (Exception e)
        {
            _logger.LogError(null, e);
            response.ApiHttpStatusCode = (int)HttpStatusCode.InternalServerError;
            response.RawPayload = e.Message;
        }

        return response;
    }
    
    public async Task<ApiResponse<TResponse?>> PutAsync<TResponse, TRequest>(string url, TRequest request)
    {
        var response = new ApiResponse<TResponse?>();

        try
        {
            var apiResponse = await _client.PostAsJsonAsync(url, request);
            response.ApiHttpStatusCode = (int)apiResponse.StatusCode;
            response.RawPayload = await apiResponse.Content.ReadAsStringAsync();

            switch (response.ApiHttpStatusCode)
            {
                case >= 200 and <= 299 when string.IsNullOrWhiteSpace(response.RawPayload) == false:
                    response.Payload = await apiResponse.Content.ReadFromJsonAsync<TResponse>();
                    break;
                case < 200 or > 299:
                    if (string.IsNullOrWhiteSpace(response.RawPayload) == false) _logger.LogWarning("Not success http status code from api: {ResponseRawPayload}", response.RawPayload);
                    break;
            }
        }
        catch (Exception e)
        {
            _logger.LogError(null, e);
            response.ApiHttpStatusCode = (int)HttpStatusCode.InternalServerError;
            response.RawPayload = e.Message;
        }

        return response;
    }
    
    public async Task<ApiResponse<object>> DeleteAsync(string url)
    {
        var response = new ApiResponse<object>();

        try
        {
            var apiResponse = await _client.DeleteAsync(url);
            response.ApiHttpStatusCode = (int)apiResponse.StatusCode;
            response.RawPayload = await apiResponse.Content.ReadAsStringAsync();

            switch (response.ApiHttpStatusCode)
            {
                case < 200 or > 299:
                    if (string.IsNullOrWhiteSpace(response.RawPayload) == false) _logger.LogWarning("Not success http status code from api: {ResponseRawPayload}", response.RawPayload);
                    break;
            }
        }
        catch (Exception e)
        {
            _logger.LogError(null, e);
            response.ApiHttpStatusCode = (int)HttpStatusCode.InternalServerError;
            response.RawPayload = e.Message;
        }

        return response;
    }
}