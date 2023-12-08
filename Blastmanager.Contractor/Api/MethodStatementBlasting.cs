namespace Blastmanager.Contractor.Api;

/// <summary>
/// </summary>
public class MethodStatementBlasting
{
    /// <summary>
    /// Identifier
    /// </summary>
    public int Id { get; internal set; }

    /// <summary>
    /// Time for when blast plan was last published
    /// </summary>
    public DateTime LastPublished { get; internal set; }

    /// <summary>
    /// Latest revision number
    /// </summary>
    public int LastRevision { get; internal set; }

    /// <summary>
    /// Title of blast plan
    /// </summary>
    public string Title { get; internal set; } = null!;

    /// <summary>
    /// List of polygons pointing out blast area
    /// </summary>
    public List<Polygon> Polygon { get; internal set; } = new();
}