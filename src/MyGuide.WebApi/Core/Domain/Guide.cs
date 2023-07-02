namespace MyGuide.WebApi.Core.Domain;

/// <summary>
/// Entity that represents a guide
/// </summary>
public class Guide : BaseEntity
{

    /// <summary>
    /// Id of guide owner
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Guide title
    /// </summary>
    [MaxLength(50)]
    public string Title { get; set; }

    /// <summary>
    /// Description of the guide
    /// </summary>
    [MaxLength(500)]
    public string Description { get; set; }

    /// <summary>
    /// Guide stars
    /// </summary>
    public int Stars { get; set; }

    /// <summary>
    /// Guide places
    /// </summary>
    public ICollection<Place> Places { get; set; }

    /// <summary>
    /// Guide criterions
    /// </summary>
    public ICollection<Criterion> Criterions { get; set; }
}