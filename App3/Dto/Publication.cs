namespace TravelApp1.Dto;

public class Publication
{
    public string? Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public DateTime PublishDate { get; set; }
    public string[]? FileIds { get; set; }
    public Coordinates? Coordinates { get; set; }
}

public class Coordinates
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }
}