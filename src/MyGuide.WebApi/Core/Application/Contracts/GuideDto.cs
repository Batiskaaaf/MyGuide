namespace MyGuide.WebApi.Core.Application.Contracts;

/// <summary>
/// Guide data transfer object
/// </summary>
public class GuideDto
{
    /// <summary>
    /// Identifier of guide owner
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Guide title
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Description of the guide
    /// </summary>
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