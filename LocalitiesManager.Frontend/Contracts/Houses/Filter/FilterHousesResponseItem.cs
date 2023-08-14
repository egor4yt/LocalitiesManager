namespace LocalitiesManager.Frontend.Contracts.Houses.Filter;

public class FilterHousesResponseItem
{
    public long Id { get; set; }
    public string Number { get; set; }
    public string StreetName { get; set; }
    public string StreetPrefix { get; set; }
    public string LocalityName { get; set; }
    public string LocalityPrefix { get; set; }
    public string ApartmentsCount { get; set; }
}