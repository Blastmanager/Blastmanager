namespace Blastmanager.Contractor.Entities.Response;

public class GetMisfireResponse
{
    /// <summary>
    /// Identifier for hole in BlastManager
    /// </summary>
    public int Id { get; init; }
    /// <summary>
    /// Time for when misfire was created in BlastManager
    /// </summary>
    public DateTime TimestampCreated { get; init; }
    /// <summary>
    /// Time for when misfire was found
    /// </summary>
    public DateTime TimestampFound { get; init; }
    /// <summary>
    /// Time for when misfire was last changed
    /// </summary>
    public DateTime TimestampLastChanged { get; init; }
    /// <summary>
    /// Identifier for misfire in BlastManager
    /// </summary>
    public int ProjectId { get; init; }
    /// <summary>
    /// Name of project
    /// </summary>
    public string ProjectName { get; init; } = null!;
    /// <summary>
    /// Intern project number
    /// </summary>
    public string ProjectNumber { get; init; } = null!;
    /// <summary>
    /// Number representation of the status
    /// </summary>
    public int StatusId { get; init; }
    /// <summary>
    /// Misfire status, 1 = Active, 2 = Neutral
    /// </summary>
    public string Status { get; init; } = null!;
    /// <summary>
    /// Reference to salve. Value is NULL if misfire is not associated with a blast
    /// </summary>
    public int? BlastId { get; init; }
    /// <summary>
    /// Amount of explosives (kg)
    /// </summary>
    public decimal? AmountExplosives { get; init; }
    /// <summary>
    /// Amount of detonators
    /// </summary>
    public decimal? AmountDetonators { get; init; }
    /// <summary>
    /// Amount of detonating cord (m)
    /// </summary>
    public decimal? AmountCord { get; init; }
    /// <summary>
    /// Amount of primers
    /// </summary>
    public decimal? AmountPrimers { get; init; }
    /// <summary>
    /// Source (ie. previous entry price)
    /// </summary>
    public string Source { get; init; } = null!;
}