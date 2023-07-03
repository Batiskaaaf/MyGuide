

namespace MyGuide.WebApi.Controllers;

/// <summary>
/// Controller for managing user guids
/// </summary>
[Route("api/v1/[controller]")]
[ApiController]
[Authorize]
public class GuidesController : ControllerBase
{
    private readonly IGuideService guideService;
    private readonly IMapper mapper;

    /// <summary>
    /// Ctor with dependencies
    /// </summary>
    public GuidesController(
        IGuideService guideService,
        IMapper mapper
    )
    {
        this.guideService = guideService;
        this.mapper = mapper;
    }

    /// <summary>
    /// Gets all user guides
    /// </summary>
    /// <param name="userId">User identifier</param>
    /// <returns>List of users guides</returns>
    [HttpGet]
    [AllowAnonymous]
    [Route("~/api/v1/{userId}/[controller]")]
    public async Task<ActionResult<IEnumerable<GuideShortResponce>>> GetUsersGuidesAsync(Guid userId)
    {
        var guidesDto = await guideService.GetUsersGuidesAsync(userId);
        var guidesShortResponce = mapper.Map<IEnumerable<GuideShortResponce>>(guidesDto);
        return Ok(guidesShortResponce);
    }
}