namespace MyGuide.WebApi.Core.Domain.Models;

/// <summary>
/// Represents commentary of guide
/// </summary>
public class Commentary : BaseEntity
{
    /// <summary>
    /// Identifier of commentary creator
    /// </summary>
    [Required]
    public Guid UserId { get; set; }

    /// <summary>
    /// Commentary data
    /// </summary>
    [MaxLength(250)]
    [Required]
    public string Data { get; set; }

    /// <summary>
    /// Commented guide
    /// </summary>
    [Required]
    public Guide Guide { get; set; }
}