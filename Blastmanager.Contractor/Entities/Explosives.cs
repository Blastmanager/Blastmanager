namespace Blastmanager.Contractor.Entities;

public class Explosives
{
    /// <summary>
    /// Theoretical calculated amount of explosives based on form from salveplan
    /// </summary>
    public decimal TheoreticalPlan { get; internal set; }

    /// <summary>
    /// Theoretical calculated amount of explosives based on form from salveraport
    /// </summary>
    public decimal TheoreticalReport { get; internal set; }
    
    /// <summary>
    /// 
    /// </summary>
    public decimal? Actual { get; internal set; }
}