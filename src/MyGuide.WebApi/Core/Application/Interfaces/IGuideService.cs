namespace MyGuide.WebApi.Core.Application.Interfaces;

/// <summary>
/// Working with guide business logic
/// </summary>
public interface IGuideService
{
    /// <summary>
    /// Creates new guide
    /// </summary>
    /// <param name="guideDto">Guide data transfer object</param>
    public Task<Guid> CreateGuideAsync(GuideDto guideDto);

    /// <summary>
    /// Deletes a guide by identifier
    /// </summary>
    /// <param name="id">Guide identifer</param>
    public Task DeleteGuideAsync(Guid id);

    /// <summary>
    /// Gets all users guides
    /// </summary>
    /// <param name="id">User identifer</param>
    /// <returns>List of guides</returns>
    public Task<IEnumerable<GuideDto>> GetUsersGuidesAsync(Guid id);

    /// <summary>
    /// User liked guide
    /// </summary>
    /// <param name="userId">User identifier</param>
    /// <param name="guideId">Guide identifier</param>
    public Task LikeGuideByUser(Guid userId, Guid guideId);
}