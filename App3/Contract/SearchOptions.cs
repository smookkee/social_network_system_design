using TravelApp1.Dto;

namespace TravelApp1.Contract;

public class SearchOptions
{
    public PageInfo? PageInfo { get; set; }
    public string? SearchText { get; set; }
    public Coordinates? Coordinates { get; set; }
    public int Radius { get; set; }
}