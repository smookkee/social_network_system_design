using Microsoft.AspNetCore.Mvc;
using TravelApp1.Contract;
using TravelApp1.Dto;

namespace TravelApp1.Controllers;

[Route("api/v1/feed")]
[ApiController]
public class FeedController : ControllerBase
{
    /// <summary>
    /// Получение общей ленты
    /// </summary>
    /// <param name="pageInfo">Настройки запрашиваемой страницы</param>
    /// <returns></returns>
    [HttpPost]
    public ActionResult<PagingResult<Publication>> GetFeed(PageInfo pageInfo)
    {
        var res = new PagingResult<Publication>();
        return Ok(res);
    }
    
    /// <summary>
    /// Получение ленты подписок
    /// </summary>
    /// <param name="pageInfo">Настройки запрашиваемой страницы</param>
    /// <returns></returns>
    [HttpPost("subscriptions")]
    public ActionResult<PagingResult<Publication>> GetUserFeed(PageInfo pageInfo)
    {
        var res = new PagingResult<Publication>();
        return Ok(res);
    }
}