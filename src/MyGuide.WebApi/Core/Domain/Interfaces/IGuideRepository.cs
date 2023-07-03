namespace MyGuide.WebApi.Core.Domain.Interfaces;

/// <summary>
/// Generic interface for working with guides data
/// </summary>
public interface IGuideRepository
{
    /// <summary>
    /// Gets user guides by id
    /// </summary>
    /// <param name="id">User idnetifier</param>
    /// <returns>List of guides</returns>
    Task<IEnumerable<Guide>> GetByUserId(Guid id);
}