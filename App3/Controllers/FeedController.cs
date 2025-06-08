using App3.Contract;
using App3.Dto;
using Microsoft.AspNetCore.Mvc;

namespace App3.Controllers;

/// <summary>
/// Контроллер пуюбликаций
/// </summary>
[Route("api/v1/feed")]
[ApiController]
public class FeedController : ControllerBase
{
    /// <summary>
    /// Получение общей ленты
    /// </summary>
    /// <param name="pageNumber">Номер запрашиваемой страницы</param>
    /// <param name="pageSize">Количество комментариев на странице</param>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ActionResult<PagingResult<Publication>>))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiError))]
    [ProducesResponseType(StatusCodes.Status401Unauthorized, Type = typeof(ApiError))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ApiError))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ApiError))]
    public ActionResult<PagingResult<Publication>> GetFeed([FromQuery] int pageNumber = 1,[FromQuery] int pageSize = 10)
    {
        var res = new PagingResult<Publication>();
        return Ok(res);
    }
    
    /// <summary>
    /// Получение подписок
    /// </summary>
    /// <param name="pageNumber">Номер запрашиваемой страницы</param>
    /// <param name="pageSize">Количество комментариев на странице</param>
    /// <returns></returns>
    [HttpGet("subscriptions")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ActionResult<PagingResult<Publication>>))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiError))]
    [ProducesResponseType(StatusCodes.Status401Unauthorized, Type = typeof(ApiError))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ApiError))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ApiError))]
    public ActionResult<PagingResult<Publication>> GetUserFeed([FromQuery] int pageNumber = 1,[FromQuery] int pageSize = 10)
    {
        var res = new PagingResult<Publication>();
        return Ok(res);
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