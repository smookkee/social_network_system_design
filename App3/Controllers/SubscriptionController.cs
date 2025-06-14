using App3.Contract;
using App3.Dto;
using Microsoft.AspNetCore.Mvc;

namespace App3.Controllers;

/// <summary>
/// Контроллер подписок
/// </summary>
[Route("api/v1/subscriptions")]
[ApiController]
public class SubscriptionController: ControllerBase
{
    /// <summary>
    /// Получение подписок
    /// </summary>
    /// <param name="pageNumber">Номер запрашиваемой страницы</param>
    /// <param name="pageSize">Количество комментариев на странице</param>
    /// <returns></returns>
    [HttpGet()]
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
}