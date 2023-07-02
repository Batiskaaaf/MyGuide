namespace MyGuide.WebApi.Infrastructure.DataAccess;

/// <summary>
/// EfCore context for working with database
/// </summary>
public class MyGuideDbContext : DbContext
{
    /// <summary>
    /// Ctor
    /// </summary>
    public MyGuideDbContext(DbContextOptions<MyGuideDbContext> contextOptions) : base(contextOptions)
    {       
    }

    /// <summary>
    /// Represents Guide table in db
    /// </summary>
    public DbSet<Guide> Guides { get; set; }

    /// <summary>
    /// Represents Criterion table in db
    /// </summary>
    public DbSet<Criterion> Criteria { get; set; }

    /// <summary>
    /// Represents Commentary table in db
    /// </summary>
    public DbSet<Commentary> Commentaries { get; set; }

    /// <summary>
    /// Represents Place table in db
    /// </summary>
    public DbSet<Place> Places { get; set; }

    /// <summary>
    /// Represents Assessment table in db
    /// </summary>
    public DbSet<Assessment> Assessments { get; set; }

}