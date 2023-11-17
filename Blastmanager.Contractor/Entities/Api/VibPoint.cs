namespace Blastmanager.Contractor.Entities.Api;

public abstract class VibPoint : Coordinate
{
    /// <summary>
    /// Identifier for measurement point
    /// </summary>
    public int Id { get; init; }
    /// <summary>
    /// Name of provider to value
    /// </summary>
    public string Provider { get; init; } = null!;
    /// <summary>
    /// Remark of vibration point, ie. "MP01"
    /// </summary>
    public string Name { get; init; } = null!;
    /// <summary>
    /// Placement of vibration point. ie. address
    /// </summary>
    public string Placement { get; init; } = null!;
    /// <summary>
    /// Time for when measurement point was activated
    /// </summary>
    public DateTime ActivationDate { get; init; }
    /// <summary>
    /// Time for when measurement point was deactivated
    /// </summary>
    public DateTime? DeactivationDate { get; init; }
    /// <summary>
    /// Type of instrument
    /// </summary>
    public string Instrument { get; init; } = null!;
    /// <summary>
    /// Whether measurement point is still active or deactivated
    /// </summary>
    public bool IsActive { get; init; }

    /// <summary>
    /// Limit value for vibration
    /// </summary>
    public decimal Limit { get; init; }
    /// <summary>
    /// Comment to limit
    /// </summary>
    public string LimitComment { get; init; } = null!;
    /// <summary>
    /// Time measurement point was created in BlastManager
    /// </summary>
    public DateTime Created { get; init; }
}