namespace Blastmanager.Contractor.Api;

public class VibPoint : Coordinate
{
    /// <summary>
    /// Identifier for measurement point
    /// </summary>
    public int Id { get; internal set; }

    /// <summary>
    /// Name of provider to value
    /// </summary>
    public string Provider { get; internal set; } = null!;

    /// <summary>
    /// Remark of vibration point, ie. "MP01"
    /// </summary>
    public string Name { get; internal set; } = null!;

    /// <summary>
    /// Placement of vibration point. ie. address
    /// </summary>
    public string Placement { get; internal set; } = null!;

    /// <summary>
    /// Time for when measurement point was activated
    /// </summary>
    public DateTime ActivationDate { get; internal set; }

    /// <summary>
    /// Time for when measurement point was deactivated
    /// </summary>
    public DateTime? DeactivationDate { get; internal set; }

    /// <summary>
    /// Type of instrument
    /// </summary>
    public string Instrument { get; internal set; } = null!;

    /// <summary>
    /// Whether measurement point is still active or deactivated
    /// </summary>
    public bool IsActive { get; internal set; }

    /// <summary>
    /// Limit value for vibration
    /// </summary>
    public decimal Limit { get; internal set; }

    /// <summary>
    /// Comment to limit
    /// </summary>
    public string LimitComment { get; internal set; } = null!;

    /// <summary>
    /// Time measurement point was created in BlastManager
    /// </summary>
    public DateTime Created { get; internal set; }
}