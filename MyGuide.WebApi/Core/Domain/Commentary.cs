namespace MyGuide.WebApi.Core.Domain;

/// <summary>
/// Represents commentary of guide
/// </summary>
public class Commentary : BaseEntity
{
    /// <summary>
    /// Identifier of commentary creator
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Commentary data
    /// </summary>
    [MaxLength(250)]
    public string Data { get; set; }

    /// <summary>
    /// Commented guide
    /// </summary>
    public Guide Guide { get; set; }
}