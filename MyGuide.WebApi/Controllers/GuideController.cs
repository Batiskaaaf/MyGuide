
namespace MyGuide.WebApi.Controllers;


/// <summary>
/// Controller for managing user guids
/// </summary>
[Route("[controller]")]
[ApiController]
public class GuideController : ControllerBase
{
    /// <summary>
    /// Ctor with dependencies
    /// </summary>
    public GuideController()
    {
        
    }

    /// <summary>
    /// Description
    /// </summary>
    [Authorize]
    [HttpGet]
    public ActionResult<string> GetGuidesAsync()
    {
        return Ok("Hello world");
    }
}