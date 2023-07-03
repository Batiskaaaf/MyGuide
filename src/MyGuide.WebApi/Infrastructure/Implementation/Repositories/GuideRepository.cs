namespace MyGuide.WebApi.Infrastructure.Implementation.Repositories;

/// <summary>
/// EfCore guide repository implementation
/// </summary>
public class GuideRepository : IGuideRepository
{
    private readonly MyGuideDbContext context;

    /// <summary>
    /// Ctor
    /// </summary>
    public GuideRepository(MyGuideDbContext context)
    {
        this.context = context;
    }

    /// <inheritdoc />
    public async Task<IEnumerable<Guide>> GetGuidesByUserIdAsync(Guid id)
        => await context.Guides.Where(g => g.UserId == id).ToListAsync();
        
}