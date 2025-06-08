using Microsoft.AspNetCore.Mvc;
using TravelApp1.Contract;
using TravelApp1.Dto;

namespace TravelApp1.Controllers;

[Route("api/v1/{publicationId}/comments")]
[ApiController]
public class CommentController: ControllerBase
{
    /// <summary>
    /// Добавление комментария
    /// </summary>
    /// <param name="publicationId">Id публикации</param>
    /// <param name="comment"> Комментарий</param>
    /// <returns></returns>
    [HttpPost]
    public ActionResult<Comment> AddComment([FromRoute] string publicationId, Comment comment)
    {
        return Ok(comment);
    }

    /// <summary>
    /// Постраничное получение комментариев
    /// </summary>
    /// <param name="publicationId">Id публикации</param>
    /// <param name="pageInfo">Настройки запрашиваемой страницы</param>
    /// <returns></returns>
    [HttpPost]
    public ActionResult<PagingResult<Comment>> GetComments([FromRoute] string publicationId, PageInfo pageInfo)
    {
        var result = new PagingResult<Comment>();
        return Ok(result);
    }
}