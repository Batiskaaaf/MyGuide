namespace MyGuide.WebApi.Core.Domain.Models;

/// <summary>
/// Entity that represents a guide
/// </summary>
public class Guide : BaseEntity
{
    /// <summary>
    /// Identifier of guide owner
    /// </summary>
    [Required]
    public Guid UserId { get; set; }

    /// <summary>
    /// Guide title
    /// </summary>
    [MaxLength(50)]
    [Required]
    public string Title { get; set; }

    /// <summary>
    /// Description of the guide
    /// </summary>
    [MaxLength(500)]
    public string Description { get; set; }

    /// <summary>
    /// Guide stars
    /// </summary>
    [Required]
    public int Stars { get; set; } = 0;

    /// <summary>
    /// Guide places
    /// </summary>
    public ICollection<Place> Places { get; set; }

    /// <summary>
    /// Guide criterions
    /// </summary>
    public ICollection<Criterion> Criterions { get; set; }
}