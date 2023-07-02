namespace MyGuide.WebApi.Extensions;

/// <summary>
/// Some extensions for simplifying configurations of services
/// </summary>
public static class ConfigurationExtensions
{
    /// <summary>
    /// Gets requere value in configuration or throws exception
    /// </summary>
    public static string GetRequiredValue(this IConfiguration configuration, string name) =>
        configuration[name] ?? throw new InvalidOperationException($"Configuration missing value for: {(configuration is IConfigurationSection s ? s.Path + ":" + name : name)}");

    /// <summary>
    /// Gets requere connection string or throws exception
    /// </summary>
    public static string GetRequiredConnectionString(this IConfiguration configuration, string name) =>
        configuration.GetConnectionString(name) ?? throw new InvalidOperationException($"Configuration missing value for: {(configuration is IConfigurationSection s ? s.Path + ":ConnectionStrings:" + name : "ConnectionStrings:" + name)}");

}