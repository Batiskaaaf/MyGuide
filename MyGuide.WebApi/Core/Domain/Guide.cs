namespace MyGuide.WebApi.Core.Domain;

/// <summary>
/// Entity that represents a guide
/// </summary>
public class Guide : BaseEntity
{
    /// <summary>
    /// Guide title
    /// </summary>
    public string Title { get; set; }

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