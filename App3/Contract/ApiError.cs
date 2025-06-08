namespace App3.Contract;

/// <summary>
/// Объект с описанием ошибки
/// </summary>
public class ApiError
{
    public int StatusCode { get; set; }
    public string ErrorCode { get; set; }
    public string Message { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}