
namespace MyGuide.WebApi.Core.Domain;

/// <summary>
/// Entity that represents an assessment by special criterion of a place
/// </summary>
public class Assessment : BaseEntity
{
    /// <summary>
    /// The reason of the assessment
    /// </summary>
    [MaxLength(100)]
    public string Description { get; set; }

    /// <summary>
    /// Assessment score
    /// </summary>
    public float Score { get; set; }

    /// <summary>
    /// Place that was assessed
    /// </summary>
    public Place Place { get; set; }

    /// <summary>
    /// Criterion of assessment
    /// </summary>
    public Criterion Criterion { get; set; }
}