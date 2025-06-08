using App3.Contract;
using App3.Dto;
using Microsoft.AspNetCore.Mvc;

namespace App3.Controllers;

/// <summary>
/// Контроллер для работы с комментариями
/// </summary>
[Route("api/v1/{publicationId}/comments")]
[ApiController]
public class CommentController: ControllerBase
{
    /// <summary>
    /// Добавление комментария
    /// </summary>
    /// <param name="publicationId">Id поста</param>
    /// <param name="comment">Комментарий</param>
    /// <returns></returns>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ActionResult<Comment>))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiError))]
    [ProducesResponseType(StatusCodes.Status401Unauthorized, Type = typeof(ApiError))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ApiError))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ApiError))]
    public ActionResult<Comment> CreateComment([FromRoute] string publicationId,[FromBody] Comment comment)
    {
        return Ok(comment);
    }

    /// <summary>
    /// Постраничное получение комментариев
    /// </summary>
    /// <param name="publicationId">Id поста</param>
    /// <param name="pageNumber">Номер запрашиваемой страницы</param>
    /// <param name="pageSize">Количество комментариев на странице</param>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ActionResult<PagingResult<Comment>>))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiError))]
    [ProducesResponseType(StatusCodes.Status401Unauthorized, Type = typeof(ApiError))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ApiError))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ApiError))]
    public ActionResult<PagingResult<Comment>> GetComments([FromRoute] string publicationId,[FromQuery] int pageNumber = 1,[FromQuery] int pageSize = 10)
    {
        var result = new PagingResult<Comment>();
        return Ok(result);
    }
}