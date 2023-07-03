namespace MyGuide.WebApi.Mapping;

/// <summary>
/// Guide view model to guide dto mapping profile
/// </summary>
public class GuideMappingProfile : Profile
{
    /// <summary>
    /// Ctor
    /// </summary>
    public GuideMappingProfile()
    {
        CreateMap<GuideDto, GuideShortResponce>();
    }
}