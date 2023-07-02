namespace MyGuide.WebApi.Core.Domain.Models;

/// <summary>
/// Entity that represents a place
/// </summary>
public class Place : BaseEntity
{

    /// <summary>
    /// Place title
    /// </summary>
    [MaxLength(50)]
    public string Title { get; set; }

    /// <summary>
    /// Place description
    /// </summary>
    [MaxLength(250)]
    public string Description { get; set; }

    /// <summary>
    /// Place coordinates (according to google maps)
    /// </summary>
    public string Coordinates { get; set; }

    /// <summary>
    /// Guide that contains this place
    /// </summary>
    [Required]
    public Guide Guide { get; set; }

    /// <summary>
    /// Assesments of the place
    /// </summary>
    public ICollection<Assessment> Assessments { get; set; }
}