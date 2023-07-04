

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

    /// <summary>
    /// Swagger gen configuration method
    /// </summary>   
    public static IServiceCollection ConfigureSwaggerGen(this IServiceCollection services)
    {
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Version = "v1",
                Title = "MyGuide.WebApi",
                Description = "ASP.NET Core Web Api for managing guides"
            });
            
            var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
        });
        return services;
    }

    /// <summary>
    /// Identity service register method
    /// </summary>
    public static IServiceCollection AddIdentityService(this IServiceCollection services)
    {
        services.AddTransient<IIdentityService, IdnetityService>();
        return services;
    }
}