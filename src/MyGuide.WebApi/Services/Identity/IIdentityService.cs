namespace MyGuide.WebApi.Services.Identity;

/// <summary>
/// Interface for working with user identity (JWT)
/// </summary>
public interface IIdentityService
{
    /// <summary>
    /// Gets user identifier
    /// </summary>
    string GetUserIdentity();

    /// <summary>
    /// Gets username
    /// </summary>
    string GetUserName();
}