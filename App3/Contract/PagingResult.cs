namespace TravelApp1.Contract;

public class PagingResult<T>
{
    public int? CurrentPage { get; set; }
    public int? NextPage { get; set; }
    public int? TotalItems { get; set; }
    public List<T>? Items { get; set; }
}