using Microsoft.AspNetCore.Mvc;
using TravelApp1.Dto;

namespace TravelApp1.Controllers;

[Route("api/v1/images")]
[ApiController]
public class FileController: ControllerBase
{
    /// <summary>
    /// Загрузить изображение в форму редактирования публикации
    /// </summary>
    /// <param name="publicationId">Id публикации</param>
    /// <param name="image">Изображение в виде массива байт</param>
    /// <returns>Id загруженного изображения в хранилище</returns>
    [HttpPost("{publicationId}/image")]
    public ActionResult<string> AddImage([FromRoute] string publicationId, byte[] image)
    {
        var id = "imageId";
        return Ok(id);
    }
    
    /// <summary>
    /// Получить изображения публикации
    /// </summary>
    /// <returns>Изображение</returns>
    [HttpGet("{publicationId}")]
    public ActionResult<FeedFile> GetImages([FromRoute] string publicationId)
    {
        var res = new FeedFile()
        {
            PublicationId = publicationId,
            Files = Array.Empty<IFormFile>(),
        };
        
        return Ok(res);
    }
    
    /// <summary>
    /// Получить изображения публикаций для ленты
    /// </summary>
    /// <param name="publicationIds"></param>
    /// <returns></returns>
    [HttpGet]
    public ActionResult<List<FeedFile>> GetFeedImages([FromQuery] string[] publicationIds)
    {
        var emptyFile = new FormFile(
            baseStream: Stream.Null,
            baseStreamOffset: 0,
            length: 0,
            name: "file",
            fileName: "empty.txt");
        
        var feedImages = new List<FeedFile>()
        {
            new()
            {
                PublicationId = publicationIds[0],
                Files = new IFormFile[]{emptyFile}
            }
        };
        
        return Ok(feedImages);
    }
}