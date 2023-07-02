namespace MyGuide.WebApi.Controllers;

/// <summary>
/// Controller for managing user guids
/// </summary>
[Route("{userId}/[controller]")]
[ApiController]
public class GuidesController : ControllerBase
{
    /// <summary>
    /// Ctor with dependencies
    /// </summary>
    public GuidesController()
    {
    }

    /// <summary>
    /// Description
    /// </summary>
    [HttpGet]
    public ActionResult<string> GetGuidesAsync()
    {
        return Ok("Hello world");
    }
}