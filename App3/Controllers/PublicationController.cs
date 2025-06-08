using Microsoft.AspNetCore.Mvc;
using TravelApp1.Dto;

namespace TravelApp1.Controllers;

[Route("api/v1/publication")]
[ApiController]
public class PublicationController: ControllerBase
{
    /// <summary>
    /// Добавить публикацию
    /// </summary>
    /// <param name="publication">Публикация</param>
    /// <returns></returns>
    [HttpPost]
    public ActionResult<Uri> AddPublication(Publication publication)
    {
        var uri = new Uri($"http://localhost:5000/api/publication/{publication.Id}");
        return Ok(uri);
    }
    
    /// <summary>
    /// Получить публикацию по Id
    /// </summary>
    /// <param name="publicationId">Id публикации</param>
    /// <returns></returns>
    [HttpGet("{publicationId}")]
    public ActionResult<Publication> GetPublication([FromRoute] string publicationId)
    {
        var newPublication = new Publication();
        return Ok(newPublication);
    }
}