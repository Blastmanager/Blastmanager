namespace Blastmanager.Contractor.Entities.Api;

/// <summary>
/// 
/// </summary>
public class Section
{
    /// <summary>
    /// Type - Section/Element. Example: Outline, emergency room etc
    /// </summary>
    public string Type { get; init; } = null!;
    /// <summary>
    /// Hole spacing
    /// </summary>
    public decimal Spacing { get; init; }
    /// <summary>
    /// Burden
    /// </summary>
    public decimal Burden { get; init; }
    /// <summary>
    /// Ankle of hole. 0 = vertical
    /// </summary>
    public decimal HoleAngle { get; init; }
    /// <summary>
    /// Diameter in millimeter in bore hole
    /// </summary>
    public int Diameter { get; init; }
    /// <summary>
    /// Hole count
    /// </summary>
    public int Holes { get; init; }
    /// <summary>
    /// Row count
    /// </summary>
    public int Rows { get; init; }
    /// <summary>
    /// Total meter bore hole in section
    /// </summary>
    public decimal TotalHoleDepth { get; init; }
}