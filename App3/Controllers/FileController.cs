using App3.Contract;
using Microsoft.AspNetCore.Mvc;

namespace App3.Controllers;

/// <summary>
/// Контроллер загрузки изображений
/// </summary>
[Route("api/v1/images")]
[ApiController]
public class FileController: ControllerBase
{
    /// <summary>
    /// Загрузить изображение в форму редактирования поста
    /// </summary>
    /// <param name="publicationId">Id поста</param>
    /// <param name="image">Изображение в виде массива байт</param>
    /// <returns>Id загруженного изображения в хранилище</returns>
    [HttpPost("{publicationId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof( ActionResult<string>))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiError))]
    [ProducesResponseType(StatusCodes.Status401Unauthorized, Type = typeof(ApiError))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ApiError))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ApiError))]
    public ActionResult<string> AddImage([FromRoute] string publicationId,[FromBody] byte[] image)
    {
        var id = "imageId";
        return Ok(id);
    }
}