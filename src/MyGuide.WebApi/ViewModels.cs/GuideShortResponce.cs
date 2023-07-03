namespace MyGuide.WebApi.ViewModels;

/// <summary>
/// Represents a response on api call GetUsersGuidesAsync
/// </summary>
public class GuideShortResponce
{
    /// <summary>
    /// Guide title
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Guide description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Guide stars count
    /// </summary>
    public int StarsCount { get; set; }
}