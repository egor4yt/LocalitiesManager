using System.Threading.Tasks;

namespace LocalitiesManager.Frontend.Common;

public interface IApiClient
{
    Task<ApiResponse<TResponse?>> GetAsync<TResponse>(string url);
    Task<ApiResponse<TResponse?>> PostAsync<TResponse, TRequest>(string url, TRequest request);
    Task<ApiResponse<TResponse?>> PutAsync<TResponse, TRequest>(string url, TRequest request);
    Task<ApiResponse<object>> DeleteAsync(string url);
}