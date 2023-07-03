namespace MyGuide.WebApi.Infrastructure.Mapping;

/// <summary>
/// GuideDto to guide entity mapping profile
/// </summary>
public class GuideMappingProfile : Profile
{
    /// <summary>
    /// Ctor
    /// </summary>
    public GuideMappingProfile()
    {
        CreateMap<Guide,GuideDto>();
    }
}