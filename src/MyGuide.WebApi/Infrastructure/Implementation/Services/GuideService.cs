namespace MyGuide.WebApi.Infrastructure.Implementation.Services;

/// <summary>
/// Service that implements buiseness logic for managin guides
/// </summary>
public class GuideService : IGuideService
{
    private readonly IGuideRepository guideRepository;
    private readonly IMapper mapper;

    /// <summary>
    /// ctor
    /// </summary>
    public GuideService(
        IGuideRepository guideRepository,
        IMapper mapper
    )
    {
        this.guideRepository = guideRepository;
        this.mapper = mapper;
    }

    /// <inheritdoc />
    public Task<Guid> CreateGuideAsync(GuideDto guideDto)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public Task DeleteGuideAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public async Task<IEnumerable<GuideDto>> GetUsersGuidesAsync(Guid id)
    {
        var guides = await guideRepository.GetByUserId(id);
        var guidesDto = mapper.Map<IEnumerable<GuideDto>>(guides);
        return guidesDto;
    }

    /// <inheritdoc />
    public Task LikeGuideByUser(Guid userId, Guid guideId)
    {
        throw new NotImplementedException();
    }
}