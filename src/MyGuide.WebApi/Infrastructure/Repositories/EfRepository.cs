

namespace MyGuide.WebApi.Infrastructure.Repositories;

/// <summary>
/// IRepository implementaions using EFCore
/// </summary>
public class EfRepository<T> : IRepository<T> where T : BaseEntity
{
    private readonly DbSet<T> dbSet;
    private readonly MyGuideDbContext context;

    /// <summary>
    /// Ctor
    /// </summary>
    public EfRepository(MyGuideDbContext context)
    {
        dbSet = context.Set<T>();
        this.context = context;
    }

    /// <inheritdoc />
    public IQueryable<T> AsQueryable()
        => dbSet.AsQueryable();

    /// <inheritdoc />
    public async Task<Guid> InsertAsync(T entity)
    {
        await dbSet.AddAsync(entity);
        return entity.Id;
    }


    /// <inheritdoc />
    public Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> exspression)
        => dbSet.FirstOrDefaultAsync(exspression);


    /// <inheritdoc />
    public async Task UpdateAsync(Guid id, T entity)
    {
        if(await dbSet.FindAsync(id) is T found)
        {
            dbSet.Entry(found).CurrentValues.SetValues(entity);
        }
    }

    /// <inheritdoc />
    public async Task<bool> SaveChangesAsync()
    {
        return await context.SaveChangesAsync() > 0;
    }

    /// <inheritdoc />
    public void Delete(T entity)
    {
        dbSet.Remove(entity);
    }

    /// <inheritdoc />
    public async Task DeleteAsync(Guid id)
    {
        dbSet.Remove(await FirstOrDefaultAsync(e => e.Id == id));
    }
}