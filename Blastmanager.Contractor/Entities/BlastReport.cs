using Blastmanager.Contractor.Api;

namespace Blastmanager.Contractor.Entities;

/// <summary>
/// 
/// </summary>
public sealed class BlastReport
{
    internal BlastReport() { }

    /// <summary>
    /// 
    /// </summary>
    public int Id { get; internal set; }
    public int ProjectId { get; internal set; }
    public string ProjectName { get; internal set; } = null!;
    public string ProjectNumber { get; internal set; } = null!;

    public int Number { get; set; }
    public string Title { get; internal set; } = null!;
    public string Contractor { get; internal set; } = null!;
    public string Type { get; internal set; } = null!;

    public DateTime BlastPlanCreated { get; internal set; }
    public DateTime BlastReportCreated { get; internal set; }

    public DateTime PlannedFire { get; internal set; }
    public DateTime ActualFired { get; internal set; }
    public DateTime LastChanged { get; internal set; }

    public int RevisionNumber { get; internal set; }

    public decimal AreaPlan { get; internal set; }
    public decimal AreaReport { get; internal set; }

    public Volume Volume { get; internal set; } = null!;

    public int HolesPlan { get; internal set; }
    public int HolesReport { get; internal set; }

    public Drill Drill { get; internal set; }

    public Explosives Explosives { get; internal set; } = null!;
    public Movements Movements { get; internal set; } = null!;

    public int MethodStatementBlastingId { get; internal set; }

    public List<int> AsBuiltConcaveHullIdList { get; internal set; } = null!;
    public int? DirectionDegree { get; internal set; }
    public List<Product> Products { get; internal set; } = null!;
    public List<VibValue> VibValues { get; internal set; } = null!;
    public List<Section> Sections { get; internal set; } = null!;
    public List<AsBuiltHoles> AsBuiltHoles { get; internal set; } = null!;
    public int PopulationAlertReceivers { get; internal set; }
    public DateTime? PopulationAlertSentDate { get; internal set; }
    public BlasterUser Blaster { get; internal set; } = null!;
    public decimal MaxChargePerDelay { get; internal set; }
    public decimal? TunnelRoundArea { get; internal set; }
    public decimal? TunnelRoundLength { get; internal set; }
    public Coordinate Coordinates { get; internal set; } = null!;
}