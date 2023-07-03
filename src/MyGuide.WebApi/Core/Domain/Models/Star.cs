namespace MyGuide.WebApi.Core.Domain.Models;

/// <summary>
/// Represents users like of guide
/// </summary>
public class Star
{
    /// <summary>
    /// Identifier of user who liked guide
    /// </summary>
    [Required]
    public Guid UserId { get; set; }

    /// <summary>
    /// Guide that user liked
    /// </summary>
    [Required]
    public Guide Guide { get; set; }
}