namespace Blastmanager.Contractor.Entities;

public class Misfire
{
    /// <summary>
    /// Identifier for hole in BlastManager
    /// </summary>
    public int Id { get; internal set; }

    /// <summary>
    /// Time for when misfire was created in BlastManager
    /// </summary>
    public DateTime TimestampCreated { get; internal set; }

    /// <summary>
    /// Time for when misfire was found
    /// </summary>
    public DateTime TimestampFound { get; internal set; }

    /// <summary>
    /// Time for when misfire was last changed
    /// </summary>
    public DateTime TimestampLastChanged { get; internal set; }

    /// <summary>
    /// </summary>
    public decimal? Northing { get; internal set; }

    /// <summary>
    /// </summary>
    public decimal? Easting { get; internal set; }

    /// <summary>
    /// Identifier for misfire in BlastManager
    /// </summary>
    public int ProjectId { get; internal set; }

    /// <summary>
    /// Name of project
    /// </summary>
    public string ProjectName { get; internal set; } = null!;

    /// <summary>
    /// Intern project number
    /// </summary>
    public string ProjectNumber { get; internal set; } = null!;

    /// <summary>
    /// Number representation of the status
    /// </summary>
    public int StatusId { get; internal set; }

    /// <summary>
    /// Misfire status, 1 = Active, 2 = Neutral
    /// </summary>
    public string Status { get; internal set; } = null!;

    /// <summary>
    /// Reference to salve. Value is NULL if misfire is not associated with a blast
    /// </summary>
    public int? BlastId { get; internal set; }

    /// <summary>
    /// Amount of explosives (kg)
    /// </summary>
    public decimal? AmountExplosives { get; internal set; }

    /// <summary>
    /// Amount of detonators
    /// </summary>
    public decimal? AmountDetonators { get; internal set; }

    /// <summary>
    /// Amount of detonating cord (m)
    /// </summary>
    public decimal? AmountCord { get; internal set; }

    /// <summary>
    /// Amount of primers
    /// </summary>
    public decimal? AmountPrimers { get; internal set; }

    /// <summary>
    /// Source (ie. previous entry price)
    /// </summary>
    public string Source { get; internal set; } = null!;

    /// <summary>
    /// </summary>
    public string ReportedAuthority { get; internal set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string DetonatorType { get; internal set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string ExplosiveTypes { get; internal set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string PotentialReasons { get; internal set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string Primer { get; internal set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string Comment { get; internal set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string MisfireContent { get; internal set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string FixedHow { get; internal set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string ReasonText { get; internal set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string FixedHowText { get; internal set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string BlastType { get; internal set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string FoundHow { get; internal set; } = string.Empty;
}