namespace MyGuide.WebApi.Core.Domain.Models;

/// <summary>
/// Abstract entity that represents default coloumns for each row in database 
/// </summary>
public abstract class BaseEntity
{   
    /// <summary>
    /// Entity id
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Entity creation date
    /// </summary>
    public DateTime CreationDate { get; set; }
}