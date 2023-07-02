namespace MyGuide.WebApi.Extensions;


/// <summary>
/// Registering services in DI extensions
/// </summary>
public static class RegistarExtensions
{
    /// <summary>
    /// Registering db context
    /// </summary>
    public static IServiceCollection RegistarDatabaseContext(this IServiceCollection services, IConfiguration configuration)
    {
        static void ConfigureSqlOptions(SqlServerDbContextOptionsBuilder sqlOptions)
        {
            sqlOptions.MigrationsAssembly((typeof(Program).Assembly.FullName));
            sqlOptions.EnableRetryOnFailure(maxRetryCount: 5, maxRetryDelay: TimeSpan.FromSeconds(10), errorNumbersToAdd: null);
        }

        services.AddDbContext<MyGuideDbContext>(options => 
        {
            options.UseSqlServer(configuration.GetRequiredConnectionString("MyGuideWebApiDb"), ConfigureSqlOptions);
        });

        return services;
    }
}