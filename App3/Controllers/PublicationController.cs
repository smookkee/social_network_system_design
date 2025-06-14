using App3.Contract;
using App3.Dto;
using Microsoft.AspNetCore.Mvc;

namespace App3.Controllers;

[Route("api/v1/publications")]
[ApiController]
public class PublicationController: ControllerBase
{
    /// <summary>
    /// Добавить пост
    /// </summary>
    /// <param name="publication">Пост</param>
    /// <returns></returns>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ActionResult<Uri>))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiError))]
    [ProducesResponseType(StatusCodes.Status401Unauthorized, Type = typeof(ApiError))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ApiError))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ApiError))]
    public ActionResult<Uri> AddPublication(Publication publication)
    {
        var uri = new Uri($"http://localhost:5000/api/publication/{publication.Id}");
        return Ok(uri);
    }
    
    /// <summary>
    /// Получить пост по Id
    /// </summary>
    /// <param name="publicationId">Id поста</param>
    /// <returns></returns>
    [HttpGet("{publicationId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ActionResult<Publication>))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiError))]
    [ProducesResponseType(StatusCodes.Status401Unauthorized, Type = typeof(ApiError))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ApiError))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ApiError))]
    public ActionResult<Publication> GetPublication([FromRoute] string publicationId)
    {
        var newPublication = new Publication();
        return Ok(newPublication);
    }
    
    /// <summary>
    /// Поиск поста
    /// </summary>
    /// <param name="searchText"></param>
    /// <param name="radius"></param>
    /// <param name="latitude"></param>
    /// <param name="longitude"></param>
    /// <param name="pageNumber"></param>
    /// <param name="pageSize"></param>
    /// <returns></returns>
    [HttpGet("search")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ActionResult<PagingResult<Publication>>))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiError))]
    [ProducesResponseType(StatusCodes.Status401Unauthorized, Type = typeof(ApiError))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ApiError))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ApiError))]
    public ActionResult<PagingResult<Publication>> GetFeed(
        [FromQuery] string? searchText,
        [FromQuery] string? radius,
        [FromQuery] double? latitude,
        [FromQuery] double? longitude,
        [FromQuery] string? pageNumber,
        [FromQuery] string? pageSize
    )
    {
        var res = new PagingResult<Publication>();
        return Ok(res);
    }
}