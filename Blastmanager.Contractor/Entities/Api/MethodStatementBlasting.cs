namespace Blastmanager.Contractor.Entities.Api;

/// <summary>
/// 
/// </summary>
public abstract class MethodStatementBlasting
{
    /// <summary>
    /// Identifier
    /// </summary>
    public int Id { get; init; }
    
    /// <summary>
    /// Time for when blast plan was last published
    /// </summary>
    public DateTime LastPublished { get; init; }
    
    /// <summary>
    /// Latest revision number
    /// </summary>
    public int LastRevision { get; init; }

    /// <summary>
    /// Title of blast plan
    /// </summary>
    public string Title { get; init; } = null!;

    /// <summary>
    /// List of polygons pointing out blast area
    /// </summary>
    public List<Polygon> Polygon { get; init; } = new List<Polygon>();
}