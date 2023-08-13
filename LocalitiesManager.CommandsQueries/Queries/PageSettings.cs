using System.ComponentModel;

namespace LocalitiesManager.CommandsQueries.Queries;

public class PageSettings
{
    [DefaultValue(20)]
    public int Count { get; set; }
    [DefaultValue(0)]
    public int Skip { get; set; }
}