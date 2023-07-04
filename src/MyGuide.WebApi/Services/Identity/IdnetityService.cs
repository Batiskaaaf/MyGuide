namespace MyGuide.WebApi.Services.Identity;

/// <summary>
/// Identity service imlpementation
/// </summary>
public class IdnetityService : IIdentityService
{
    private readonly IHttpContextAccessor context;

    /// <summary>
    /// Ctor
    /// </summary>
    public IdnetityService(IHttpContextAccessor context)
    {
        this.context = context ?? throw new ArgumentNullException(nameof(context));
    }

    /// <inheritdoc />
    public string GetUserIdentity()
        => context.HttpContext.User.FindFirst("sub").Value;

    /// <inheritdoc />
    public string GetUserName()
        => context.HttpContext.User.Identity.Name;
}