namespace LocalitiesManager.Frontend.Common;

public class ApiResponse<T>
{
    public int ApiHttpStatusCode { get; set; }
    public string RawPayload { get; set; }
    public T Payload { get; set; }
}