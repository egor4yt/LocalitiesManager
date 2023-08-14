using System.Collections.Generic;

namespace LocalitiesManager.Frontend.Contracts.Houses.Filter;

public class FilterHousesResponse
{
    public List<FilterHousesResponseItem> Items { get; set; }
    public long Total { get; set; }
}