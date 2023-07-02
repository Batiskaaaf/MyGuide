namespace MyGuide.WebApi.Core.Interfaces;

/// <summary>
/// Generic interface for working with domain models
/// </summary>
public interface IRepository<T> where T : BaseEntity
{

    /// <summary>
    /// Returns first or default element
    /// </summary>
    /// <param name="exspression"></param>
    /// <returns><typeparamref name="T"/></returns>
    public Task<T> FirstOrDefaultAsync(Expression<Func<T,bool>> exspression);

    /// <summary>
    /// Converts to Queryable
    /// </summary>
    /// <returns>IQueryable&lt;<typeparamref name="T"/>&gt;</returns>
    public IQueryable<T> AsQueryable();

    /// <summary>
    /// Creates a new entity
    /// </summary>
    /// <param name="entity"><typeparamref name="T"/></param>
    /// <returns>Guid of new entity</returns>
    public Task<Guid> InsertAsync(T entity);

    /// <summary>
    /// Updates entity
    /// </summary>
    /// <param name="entity">Updated <typeparamref name="T"/> entity</param>
    /// <param name="id">Entity identifier</param>
    Task UpdateAsync(Guid id, T entity);

    /// <summary>
    /// Deletes entity
    /// </summary>
    /// <param name="entity">Entity <typeparamref name="T"/> to delete</param>
    void Delete(T entity);

    /// <summary>
    /// Delete entity by id
    /// </summary>
    /// <param name="id">Entity identifier</param>
    Task DeleteAsync(Guid id);

    /// <summary>
    /// Saves changes
    /// </summary>
    /// <returns>True if saved successfully, otherwise false</returns>
    Task<bool> SaveChangesAsync();
}