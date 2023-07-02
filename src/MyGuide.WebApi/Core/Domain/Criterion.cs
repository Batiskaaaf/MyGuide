namespace MyGuide.WebApi.Core.Domain;

/// <summary>
/// Entity that represents assessment criteria of a place 
/// </summary>
public class Criterion : BaseEntity
{
    /// <summary>
    /// Criterion title
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Criterion max score
    /// </summary>
    public int MaxScore { get; set; }

    /// <summary>
    /// Guide that contains this Criterion
    /// </summary>
    public Guide Guide { get; set; }
}