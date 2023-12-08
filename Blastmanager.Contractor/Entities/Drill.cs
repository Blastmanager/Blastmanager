namespace Blastmanager.Contractor.Entities;

/// <summary>
/// </summary>
public class Drill
{
    /// <summary>
    /// Amount of bore meters from salveplan
    /// </summary>
    public decimal MetersPlan { get; internal set; }

    /// <summary>
    /// Amount of bore meters from salverapport
    /// </summary>
    public decimal MetersReport { get; internal set; }

    /// <summary>
    /// Read / measured amount of bore meters
    /// </summary>
    public decimal Actual { get; internal set; }
}