using Microsoft.AspNetCore.Mvc;
using TravelApp1.Contract;
using TravelApp1.Dto;

namespace TravelApp1.Controllers;

[Route("api/v1/search/publications")]
[ApiController]
public class PublicationSearchController: ControllerBase
{
    [HttpPost]
    public ActionResult<PagingResult<Publication>> GetFeed(SearchOptions options)
    {
        var res = new PagingResult<Publication>();
        return Ok(res);
    }
}