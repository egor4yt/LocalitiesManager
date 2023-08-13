namespace LocalitiesManager.CommandsQueries.Queries;

public class PageResult<T>
{
    public List<T> Items { get; set; }
    public long Total { get; set; }
}