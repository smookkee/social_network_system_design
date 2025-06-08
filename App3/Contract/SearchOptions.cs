using App3.Dto;

namespace App3.Contract;

public class SearchOptions
{
    public PageInfo? PageInfo { get; set; }
    public string? SearchText { get; set; }
    public Coordinates? Coordinates { get; set; }
    public int Radius { get; set; }
}